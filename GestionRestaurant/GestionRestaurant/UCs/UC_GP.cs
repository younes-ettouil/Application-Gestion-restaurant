using GestionRestaurant.Data;
using GestionRestaurant.Entities;
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

namespace GestionRestaurant.UCs
{
    public partial class UC_GP : UserControl
    {
        private DB db = new DB();
        private Plat plat = new Plat();
        private int platNum =0 ;
        public UC_GP()
        {
            InitializeComponent();
            
        }
        public void réinitialiser()
        {
            LibelleTxtBox.Text = String.Empty;
            TyPlatTxtBox.Text = String.Empty;
            PrixTxtBox.Text = String.Empty;
            ErrLbl.Visible = false;
            ErrLbl2.Visible = false;
            ErrLbl3.Visible = false;
        }
        public void selectPlat()
        {
            platDgv.DataSource = db.Plats.ToList();
            platDgv.Columns["Contients"].Visible = false;
        }
        public void createServeur()
        {
            if (LibelleTxtBox.Text != string.Empty && TyPlatTxtBox.Text != string.Empty && PrixTxtBox.Text != string.Empty)
            {


                plat.libelle = LibelleTxtBox.Text;
                plat.type_plat = TyPlatTxtBox.Text;
                plat.prix = Convert.ToDouble(PrixTxtBox.Text);

                db.Plats.Add(plat);
                db.SaveChanges();
                selectPlat();
                MessageBox.Show("enregistrement a été ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                réinitialiser();

            }
            else
            {
                if (LibelleTxtBox.Text == string.Empty) ErrLbl.Visible = true;
                if (TyPlatTxtBox.Text == string.Empty) ErrLbl2.Visible = true;
                if (PrixTxtBox.Text == string.Empty) ErrLbl3.Visible = true;
            }
        }
        public void deletePlat(int codePlat)
        {

            plat = (Plat)db.Plats.Where(x => x.code_plat == codePlat).FirstOrDefault();

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Plats.Remove(plat);
                db.SaveChanges();
                selectPlat();
                MessageBox.Show("enregistrement a été supprimer");
                réinitialiser();
            }
            else réinitialiser();

        }

        public void updatePlat()
        {
            plat.libelle = LibelleTxtBox.Text;
            plat.type_plat = TyPlatTxtBox.Text;
            plat.prix = Convert.ToDouble(PrixTxtBox.Text);
            db.Entry(plat).State = EntityState.Modified;
            db.SaveChanges();
            selectPlat();
            MessageBox.Show("enregistrement a été Modifier", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            réinitialiser();
        }







        private void UC_GP_Load(object sender, EventArgs e)
        {
            réinitialiser();
            selectPlat();
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            createServeur();
        }


        private void modifBtn_Click(object sender, EventArgs e)
        {
            if (platNum > 0)
            {
                updatePlat();
            }
            else
            {
                MessageBox.Show("Double click pour Choisir une ligne de tablaux", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            if (platNum > 0)
            {
                deletePlat(platNum);
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

        private void platDgv_DoubleClick(object sender, EventArgs e)
        {
            if (platDgv.CurrentCell.RowIndex != -1)
            {
                platNum = Convert.ToInt32(platDgv.CurrentRow.Cells["code_plat"].Value);
                plat = db.Plats.Where(x => x.code_plat == platNum).FirstOrDefault();
                LibelleTxtBox.Text = plat.libelle.ToString();
                TyPlatTxtBox.Text = plat.type_plat.ToString();
                PrixTxtBox.Text = plat.prix.ToString();
            }
        }
    }
}
