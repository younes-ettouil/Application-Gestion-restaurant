using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Data;
using GestionRestaurant.Entities;

namespace GestionRestaurant.UCs
{
    public partial class UC_GServ : UserControl
    {
        DB db = new DB();
        Serveur serveur = new Serveur();
        private int ServNum = 0;

        public UC_GServ()
        {
            InitializeComponent();
        }

        public void réinitialiser()
        {
            NomTxtBox.Text = String.Empty;
            PrenomTxtBox.Text = String.Empty;
            ErrLbl.Visible = false;
            ErrLbl2.Visible = false;
        }

        public void selectServeur()
        {
            serveurDgv.DataSource = db.Serveurs.ToList();
            serveurDgv.Columns["Affecters"].Visible = false;
        }

        public void createServeur()
        {
            if (NomTxtBox.Text != string.Empty && PrenomTxtBox.Text != string.Empty)
            {


                serveur.nom = NomTxtBox.Text;
                serveur.prenom = PrenomTxtBox.Text;

                db.Serveurs.Add(serveur);
                db.SaveChanges();
                selectServeur();
                MessageBox.Show("enregistrement a été ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                réinitialiser();

            }
            else
            {
                if (NomTxtBox.Text == string.Empty) ErrLbl.Visible = true;
                if (PrenomTxtBox.Text == string.Empty) ErrLbl2.Visible = true;  
            }
        }

        public void deleteServeur(int numServ)
        {

            serveur = (Serveur)db.Serveurs.Where(x => x.numero_serveur == numServ).FirstOrDefault();

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Serveurs.Remove(serveur);
                db.SaveChanges();
                selectServeur();
                MessageBox.Show("enregistrement a été supprimer");
                réinitialiser();
            }
            else réinitialiser();

        }

        public void updateServeur()
        {
            serveur.nom = NomTxtBox.Text;
            serveur.prenom = PrenomTxtBox.Text;
            db.Entry(serveur).State = EntityState.Modified;
            db.SaveChanges();
            selectServeur();
            MessageBox.Show("enregistrement a été Modifier", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            réinitialiser();
        }

        private void UC_GServ_Load(object sender, EventArgs e)
        {
            réinitialiser();
            selectServeur();
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            createServeur();    
        }

        private void modifBtn_Click(object sender, EventArgs e)
        {

            if (ServNum > 0)
            {
                updateServeur();
            }
            else
            {
                MessageBox.Show("Double click pour Choisir une ligne de tablaux", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            if (ServNum > 0)
            {
                deleteServeur(ServNum);
            }
            else
            {
                MessageBox.Show("Double click pour Choisir une ligne de tablaux", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void annulBtn_Click(object sender, EventArgs e)
        {
            réinitialiser();
        }


        private void serveurDgv_DoubleClick(object sender, EventArgs e)
        {
            if (serveurDgv.CurrentCell.RowIndex != -1)
            {
                ServNum = Convert.ToInt32(serveurDgv.CurrentRow.Cells["numero_serveur"].Value);
                serveur = db.Serveurs.Where(x => x.numero_serveur == ServNum).FirstOrDefault();
                NomTxtBox.Text = serveur.nom.ToString();
                PrenomTxtBox.Text = serveur.prenom.ToString();

            }
        }
    }
}
