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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChkBox_SHA1.Checked = true;                 // par défaut valide le sha1
            RadButInf_Kilo.Checked = true;              // par défaut interval inférieure taille fichier en Kilo
            RadButSup_Giga.Checked = true;              // par défaut interval supèrieure taille fichier en Kilo
            NumUpDown_Inf.Value = 1;                    // Borne inférieur d'étude fichier 1Ko
            NumUpDown_Sup.Value = 10;                   // Borne supérieur d'étude fichier 10Go
        }

        Form_RepSrc FormDossierSrc;                     // pour instance form_RepSrc

        // Propriété qui renvoie le chemin du dossier corbeille
        // Note: Ce n'est pas la corbeille système !
        // Révision: 22032020 (non utilisé actuellement)
        //
        public string CheminDossierSupprime
        {
            get { return Tbx_RepDel.Text; }
        }


        // Affiche une boite de dialogue pour le choix du dossier à scanner pour les doublons
        // Révision: 22032020
        //
        private void Btn_FixeRepSrc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Tbx_RepSrc.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        // Affiche une boitier de dialogue pour le choix du dossier corbeille de récupération
        // Note: Ce n'est pas la corbeille système !
        // Remarque: il faudra ajouter un test différent du répertoire source !
        // Révision: 22032020
        //
        private void Btn_FixeRepDel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Tbx_RepDel.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        // Gestion du bouton de recherche de doublons
        // rappel: le SHA1 sera validé par défaut
        // Révision: 22032020
        //
        private void Btn_RechercheDoublons_Click(object sender, EventArgs e)
        {
            Hashing.FctHash Hash = null;            // par défaut pas de fonction déléguée
            string StrHash=string.Empty;            // par défaut vide, désignation de la colonne type de hash
            long[] Inter;

            if (ChkBox_MD5.Checked == true)         // on fixe la fonction déléguée
            {
                Hash = new Hashing.FctHash(Hashing.Md5.MD5HashFile);        // pointe sur la fonction de hash MD5 
                StrHash = "MD5";
            }
            if (ChkBox_SHA1.Checked == true)
            {
                Hash = new Hashing.FctHash(Hashing.Sha1.SHA1HashFile);      // pointe sur la fonction de hash SHA1
                StrHash = "SHA1";
            }
            if (ChkBox_256.Checked == true)
            {
                Hash = new Hashing.FctHash(Hashing.Sha256.SHA256HashFile);  // pointe sur la fonction de hash SHA256
                StrHash = "SHA256";
            }
            if (ChkBox_384.Checked == true){
                Hash = new Hashing.FctHash(Hashing.Sha384.SHA384HashFile);  // pointe sur la fonction de hash SHA384
                StrHash="SHA384";
            }
            if (ChkBox_512.Checked == true)
            {
                Hash = new Hashing.FctHash(Hashing.Sha512.SHA512HashFile);  // pointe sur la fonction de hash SHA512
                StrHash="SHA512";
            }

            if ((Tbx_RepSrc.Text == Tbx_RepDel.Text) && Tbx_RepSrc.Text != "")
            {
                Tbx_MessageEtat.Text = "Le répertoire à analyser ne peut être identique au dossier de corbeille";
                Tbx_MessageEtat.Refresh();
                Btn_RechercheDoublons.Enabled = true;
                return;
            }

            Inter = ParseTailleMinMax();  // calcul valeur interval d'étude

            if (Tbx_RepSrc.Text != "" && Tbx_RepDel.Text != "")
            {
                Tbx_MessageEtat.Text = "Calcul des empreintes en cours, veuillez patienter...";
                Tbx_MessageEtat.Refresh();
                Btn_RechercheDoublons.Enabled = false;
                FormDossierSrc = new Form_RepSrc(Tbx_RepSrc.Text, Hash, StrHash,Inter);
                if (FormDossierSrc.Err != true)
                {
                    FormDossierSrc.Show();
                    Tbx_MessageEtat.Text = "Veuillez vérifier les fichiers ...";
                    Tbx_MessageEtat.Refresh();
                }
                else
                {
                    Tbx_MessageEtat.Text = "Erreur détecter !, Veuillez vérifier les dossiers...";
                    Tbx_MessageEtat.Refresh();

                }
            }
            else{
              Tbx_MessageEtat.Text = "Veuillez référencer les champs ci-dessus !!";
              Tbx_MessageEtat.Refresh();
              Btn_RechercheDoublons.Enabled = true;
            }

            // si présence d'item (fichier) dans FormDossierSrc
            if (FormDossierSrc != null) FormDossierSrc.ChercheDoublons(ChkBox_CocheDoublons.Checked);
        }

        // Vérifie les valeurs, intervalle d'étude, de la taille des fichiers
        // Révision: 22032020
        //
        private long[] ParseTailleMinMax()
        {
            long TailleMin = 1, TailleMax = 1;
            int MultiMin = 1, MultiMax = 1;
            
            if (RadButInf_Octet.Checked) MultiMin = 1;
            if (RadButInf_Kilo.Checked) MultiMin = 1024;
            if (RadButInf_Mega.Checked) MultiMin = 1024 * 1024;
            if (RadButInf_Giga.Checked) MultiMin = 1024 * 1024 * 1024;

            TailleMin = (long)NumUpDown_Inf.Value * MultiMin;

            if (RadButSup_Octet.Checked) MultiMax = 1;
            if (RadButSup_Kilo.Checked) MultiMax = 1024;
            if (RadButSup_Mega.Checked) MultiMax = 1024 * 1024;
            if (RadButSup_Giga.Checked) MultiMax = 1024 * 1024 * 1024;

            TailleMax = (long)NumUpDown_Sup.Value * MultiMax;
            return new long[] { TailleMin, TailleMax };      // renvoie l'intervalle
        }

        // gestion case à cocher ChkBox_MD5, choix 1 parmis 5
        // Révision: 22032020
        //
        private void ChkBox_MD5_Click(object sender, EventArgs e)
        {
            ChkBox_SHA1.Checked = false;
            ChkBox_256.Checked = false;
            ChkBox_384.Checked = false;
            ChkBox_512.Checked = false;
        }
        
        // gestion case à cocher ChkBox_SHA1, choix 1 parmis 5
        // Révision: 22032020
        //
        private void ChkBox_SHA1_Click(object sender, EventArgs e)
        {
            ChkBox_MD5.Checked = false;
            ChkBox_256.Checked = false;
            ChkBox_384.Checked = false;
            ChkBox_512.Checked = false;
        }

        // gestion case à cocher ChkBox_SHA256, choix 1 parmis 5
        // Révision: 22032020
        //
        private void ChkBox_256_Click(object sender, EventArgs e)
        {
            ChkBox_MD5.Checked = false;
            ChkBox_SHA1.Checked = false;
            ChkBox_384.Checked = false;
            ChkBox_512.Checked = false;
        }

        // gestion case à cocher ChkBox_SHA384, choix 1 parmis 5
        // Révision: 22032020
        //
        private void ChkBox_384_Click(object sender, EventArgs e)
        {
            ChkBox_MD5.Checked = false;
            ChkBox_SHA1.Checked = false;
            ChkBox_256.Checked = false;
            ChkBox_512.Checked = false;
        }

        // gestion case à cocher ChkBox_SHA512, choix 1 parmis 5
        // Révision: 22032020
        //
        private void ChkBox_512_Click(object sender, EventArgs e)
        {
            ChkBox_MD5.Checked = false;
            ChkBox_SHA1.Checked = false;
            ChkBox_256.Checked = false;
            ChkBox_384.Checked = false;
        }

        // gestion pour quitter l'application
        // Révision: 22032020
        //
        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // gestion de la suppression des doublons
        // sur les deux formes (Form_RepSrc et Form_RepDst)
        // Révision: 22032020
        //
        private void Btn_SupprDoublons_Click(object sender, EventArgs e)
        {
            if (Tbx_RepDel.Text != "" && Tbx_RepDel.Text != "")
            {
                if (FormDossierSrc != null)
                {
                    Tbx_MessageEtat.Text = "Suppression des fichiers en cours...";
                    Tbx_MessageEtat.Refresh();
                    FormDossierSrc.TraitementSupprFichiers(Tbx_RepDel.Text);
                    FormDossierSrc.Dispose();  // libération mémoire
                    Btn_RechercheDoublons.Enabled = true;
                    Tbx_MessageEtat.Text = "Opération terminée !!";
                    Tbx_MessageEtat.Refresh();
                }
            }
            else
            {
                Tbx_MessageEtat.Text = "Veuillez référencer les champs ci-dessus !!";
            }
        }

        
    }
}
