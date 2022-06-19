using GestionRestaurant.Data;
using GestionRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRestaurant.UCs

{ 
    public partial class UC_Affectation : UserControl
    {
        DB db = new DB();
        Affecter affectation = new Affecter();
        Serveur serveur = new Serveur();
        Table table = new Table();  
        public UC_Affectation()
        {
            InitializeComponent();
            chargerComBoxs();
        }

        public void chargerComBoxs()
        {


            numTableComBox.DataSource = db.Tables.Select(x => x.numero_table).ToList();
            numServComBox.DataSource = db.Serveurs.Select(x => x.numero_serveur +" "+x.nom +" "+ x.prenom).ToList();
          
            numServComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }


        public void réinitialiser()
        {
            numTableComBox.Text = String.Empty;
            numServComBox.Text = String.Empty;
            ErrLbl.Visible = false;
            ErrLbl2.Visible = false;
   
        }

        public void selectAffectation()
        { 
            affectationDgv.DataSource = (from aff in db.Affectes
                                         select new
                                         {
                                             aff.date_affectation,
                                             aff.numero_table,
                                             aff.numero_serveur,
                                             aff.Serveur.prenom,
                                             aff.Serveur.nom

                                         }).ToList();
            affectationDgv.Refresh();
/*            affectationDgv.Columns["id_aff"].Visible = false;
*/        }


        public void createAffectation()
        {
            if (numTableComBox.Text != string.Empty && numServComBox.Text != string.Empty)
            {


                affectation.numero_table = Convert.ToInt32(numTableComBox.Text);
                affectation.numero_serveur = Convert.ToInt32(numServComBox.Text.Substring(0,2));
                string date = DateTime.Now.ToString("MM-dd-yyyy");
                affectation.date_affectation = date;


                db.Affectes.Add(affectation);
                db.SaveChanges();
                selectAffectation();
                MessageBox.Show("enregistrement a été ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                réinitialiser();

            }
            else
            {
                if (numTableComBox.Text == string.Empty) ErrLbl.Visible = true;
                if (numServComBox.Text == string.Empty) ErrLbl2.Visible = true;
                
            }
        }

        private void UC_Affectation_Load(object sender, EventArgs e)
        {
            réinitialiser();
            selectAffectation();
            chargerComBoxs();
        }

        private void numServComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serveur.numero_serveur = Convert.ToInt32(numServComBox.Text.Substring(0, 1));
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            createAffectation();    
        }
    }
}
