using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AntiDoublons_Dd
{
    public partial class Form_RepSrc : Form
    {
        public Boolean Err;                          // pour etre vu par la forme principale

        private ListViewColumnSorter lvwColumnSorter; // déclaration objet ListViewColumnSorter
        private ListView ListView1 = new System.Windows.Forms.ListView();

        public Form_RepSrc(string RepertoirParent, Hashing.FctHash Hash, string Str_Hash,long[] Inter)
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
                        
            ListView1.Bounds = new Rectangle(new Point(10, 10), new Size(950, 650));  // xy,xy
            ListView1.View = View.Details;                  // afficher les détails
            ListView1.LabelEdit = true;                     // permet d'éditer les items
            ListView1.AllowColumnReorder = true;            // permet déplacer les colonnes
            ListView1.CheckBoxes = true;                    // affiche une case à cocher pour la sélection
            ListView1.FullRowSelect = true;                 // permet de sélectionner l'item et sous-items associé
            ListView1.GridLines = true;                     // affiche le quadrillage
            //       ListView1.Sorting = SortOrder.Ascending;        // effectue un tri croissant
            ListView1.Columns.Add("Nom fichier", -2, HorizontalAlignment.Left);
            ListView1.Columns.Add("Taille fichier", -2, HorizontalAlignment.Left);
            ListView1.Columns.Add("Type fichier", -2, HorizontalAlignment.Left);
            ListView1.Columns.Add("Hash " + Str_Hash, -2, HorizontalAlignment.Left);
            ListView1.Columns.Add("Répertoire", -2, HorizontalAlignment.Left);
       
            DirectoryInfo DossierParent = null;
            Err = false;
            try
            {
                DossierParent = new DirectoryInfo(RepertoirParent);
            }
            catch (Exception e8)
            {
                Console.WriteLine("Erreur {0}", e8.Message);
                MessageBox.Show(e8.Message, "Une erreur est survenue...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Err = true;
            }
            if (!Err)
            {
                ParcourirDossier(DossierParent, Hash,Inter);
                this.Controls.Add(ListView1);
                this.ListView1.ListViewItemSorter = lvwColumnSorter;
                lvwColumnSorter.SortColumn = 3;       // force le tri des empreintes par ordre croissant
                lvwColumnSorter.Order = SortOrder.Descending;
                this.ListView1.Sort();
            }
            else this.Close();
        }

        // Fixe la couleur de fond d'un item dans la listeview suivant la taille d'un fichier
        // Révision: 22032020
        //
        private Color Colorize(long TailleFichier)
        {
            long Kilo = 1024;
            long Mega = Kilo * Kilo;
            long HunMega = 100 * Mega;
            long Giga = Mega * Mega;
            Color[] clrs = new System.Drawing.Color[]
            {
                Color.Cyan,
                Color.LightGreen,
                Color.Orange,
                Color.Red
            };

            if (TailleFichier < Kilo) return clrs[0];           // blanc
            if (TailleFichier < Mega) return clrs[1];           // vert
            if (TailleFichier < HunMega) return clrs[2];        // orange
            return clrs[3];                                     // rouge
        }

        // Parcours l'ensemble des fichiers d'un dossier spécifié
        // et mise à jours des informations utiles dans la listeview
        // Révision: 22032020

        private void ParcourirFichier(DirectoryInfo Dossier, Hashing.FctHash Hash,long[] Inter)
        {
            List<FileInfo> Fichiers = new List<FileInfo>();
            try
            {
                Fichiers.AddRange(Dossier.GetFiles());
                //Console.WriteLine("Le nombre de fichier trouvé est {0} dans le dossier {1}", Fichiers.Count, Dossier.FullName);

                for (int IdxFic = 0; IdxFic < Fichiers.Count; IdxFic++)
                {
                    if ((Fichiers[IdxFic].Length > Inter[0]) && (Fichiers[IdxFic].Length < Inter[1]))
                    {
                        ListViewItem Item = new ListViewItem(Fichiers[IdxFic].Name);
                        Item.SubItems.Add(Fichiers[IdxFic].Length.ToString());
                        Item.SubItems.Add(Fichiers[IdxFic].Extension);
                        Item.SubItems.Add(Hash(Fichiers[IdxFic].FullName));
                        Item.SubItems.Add(Fichiers[IdxFic].DirectoryName);
                        // ListView1.Items.Add(Item).BackColor = Colorize(Fichiers[IdxFic].Length);
                        ListView1.Items.Add(Item).BackColor = Color.White;  // pour éviter les surcharges de couleurs
                    }
                }
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message, "Une erreur est survenue dans la fonction ParcourirFichier...");
            }
            Fichiers = null;
        }

        // Parcours l'ensemmble des dossier à partir d'un dossier parent
        // Attention à la profondeur des dossiers, appel récursif !
        // Révision: 22032020

        private void ParcourirDossier(DirectoryInfo Dossier, Hashing.FctHash Hash,long[] Inter)
        {
            if (Err != true)
            {
                ParcourirFichier(Dossier, Hash,Inter);
                try
                {
                   DirectoryInfo[] DirInfos = Dossier.GetDirectories();
                   if (DirInfos != null)  // présence de sous-répertoire ?
                   {
                      foreach (DirectoryInfo IdxDir in DirInfos)
                      ParcourirDossier(IdxDir, Hash,Inter);
                   }
                 }
                 catch (Exception e6)
                 {
                     MessageBox.Show(e6.Message, "Une erreur est survenue dans la fonction ParcourirDossier...");
                 }

             }
        }

        
        // Recherche les doublons
        // Les empreintes sont présentes dans la troisième colonne
        // En cas de doublons, la marque présence de doublon est cochée et la couleur
        // de la ligne en doublons est ajustée en fonction de la taille du fichier
        // l'astuce est de trier la colonne 3 pour faciliter la comparaison item par item
        // Révision: 22/03/2020

        public void ChercheDoublons(Boolean ChkDoublons)
        {
            int Count = ListView1.Items.Count;    // récupère le nombre d'items présent dans la liste
            int Idx = 0;
            String HashMem = String.Empty;

            lvwColumnSorter.SortColumn = 3;       // force le tri des empreintes par ordre croissant
            lvwColumnSorter.Order = SortOrder.Descending;
            this.ListView1.Sort();

            // lvwColumnSorter.SortColumn = 0;       // force le tri des nom de fichier ordre croissant
            // lvwColumnSorter.Order = SortOrder.Descending;
            // this.ListView1.Sort();

            
            if (Count >= 2)                       // présence de deux empreintes minimum sinon on arrête !
            {
                HashMem = ListView1.Items[Idx].SubItems[3].Text; // mémorise l'empreinte actuelle
                //Console.WriteLine("Nombre d'entré dans la liste: {0}", Count);

                Idx++;
                do
                {
                    //Console.WriteLine("Référence Hash de comparaison: {0}", HashMem);
                    //Console.WriteLine("Valeur de index: {0}", Idx);
                    if (ListView1.Items[Idx].SubItems[3].Text == HashMem) // compare cette empreinte à la précédente
                    {
                        if (ChkDoublons == true)
                            ListView1.Items[Idx].Checked = true;              // marque le fichier comme doublon
                        else ListView1.Items[Idx].Checked = false;

                        ListView1.Items[Idx].BackColor = Colorize(Convert.ToInt64(ListView1.Items[Idx].SubItems[1].Text)); // change la coloration sur le doublon en fonction de la taille fichier
                    }
                    else HashMem = ListView1.Items[Idx].SubItems[3].Text; // met à jour la nouvelle empreinte à comparer
                    Idx++;
                } while (Idx < Count);
            }
        }

        public async void ExportRapportDonnees()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Nom fichier,Taille fichier,Type fichier,Hash,Répertoire");
                        foreach (ListViewItem MonItem in ListView1.Items)
                        {
                            sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", MonItem.SubItems[0].Text, MonItem.SubItems[1].Text, MonItem.SubItems[2].Text, MonItem.SubItems[3].Text, MonItem.SubItems[4].Text));
                        }
                        await sw.WriteLineAsync(sb.ToString());
                        MessageBox.Show("Vos données ont été correctement exportés.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        // Gestion du traitement suppression de doublons
        // La colonne 4 contient le chemin du répertoire et la colonne 1 contient le nom du fichier
        // Recopie les doublons dans la corbeille virtuelle (l'opérateur peut ainsi revenir en arrière)
        // Note: la structure des dossiers d'origine est respectée
        // Attention à la profondeur des sous-dossiers (voir les restrictions chez microsoft)
        // Révision: 22/03/2020
        //

        public void TraitementSupprFichiers(string RepDel)
        {
            FileInfo NomFic, NomFicDst;
            string TempSrc, TempDst,TempDel;
            bool FicUse;
            int TailleChaine;

            int Count = ListView1.Items.Count;    // récupère le nombre d'items présent dans la liste
            for (int Idx = 0; Idx < Count; Idx++)
            {
                if (ListView1.Items[Idx].Checked)  // vérifie si case cochée
                {
                    TempSrc = ListView1.Items[Idx].SubItems[4].Text + "\\" + ListView1.Items[Idx].Text;
                    NomFic = new FileInfo(TempSrc);
                    //Console.WriteLine(ListView1.Items[Idx].Text);               // Nom du fichier
                    //Console.WriteLine(ListView1.Items[Idx].SubItems[1].Text);   // Taille du fichier
                    //Console.WriteLine(ListView1.Items[Idx].SubItems[2].Text);   // Extention du fichier
                    //Console.WriteLine(ListView1.Items[Idx].SubItems[3].Text);   // Empreinte Hash
                    //Console.WriteLine(ListView1.Items[Idx].SubItems[4].Text);   // Nom repertoire fichier

                    TailleChaine = ListView1.Items[Idx].SubItems[4].Text.Length;  // récupére taille chaine
                    TempDel = RepDel + "\\" + ListView1.Items[Idx].SubItems[4].Text.Substring(3, TailleChaine-3); // retire lettre lecteur source
                    TempDst = TempDel + "\\" + ListView1.Items[Idx].Text;         // dossier final  

                    try
                    {
                        // Détermine si le dossier existe déjà
                        if (Directory.Exists(TempDst) == false)
                        { 
                            // Essaye de créer le dossier.
                            DirectoryInfo di = Directory.CreateDirectory(TempDel);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Une erreur est survenue lors de la création du dossier destination...");
                    }
                    finally { }

                    NomFicDst = new FileInfo(TempDst);

                    try
                    {
                        if (!NomFicDst.Exists)       // vérifie que le fichier n'éxiste pas
                        {
                            NomFic.CopyTo(TempDst);  // recopie le fichier dans la corbeille virtuelle
                        }
                    }
                    catch (Exception e5)
                    {
                        MessageBox.Show(e5.Message, "Une erreur est survenue à l'appel de CopyTo (section exception e5)...");
                    }

                    FicUse = true;   // je suppose le fichier en cours d'utilisation (COPYTO)
                    do
                    {
                        try
                        {
                            FileStream Fic = File.OpenRead(TempSrc);  // test l'ouverture du fichier
                            Fic.Close();
                            FicUse = false;
                        }
                        catch (Exception e6)
                        {
                            MessageBox.Show(e6.Message, "Une erreur est survenue, test ouverture fichier (section exception e6)...");
                        }

                    } while (FicUse == true);  // normalement à la sortie le fichier n'est plus en cours d'utilisation
                    
                    try
                    {
                        NomFic.Delete();  // supprime le fichier d'origine
                    }
                    catch (Exception e7)
                    {
                        MessageBox.Show(e7.Message, "Une erreur est survenue, test ouverture fichier (section exception e7)...");
                    }
                }
            }
        }
    }
}


