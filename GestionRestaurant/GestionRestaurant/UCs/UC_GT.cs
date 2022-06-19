using GestionRestaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Entities;
using System.Data.Entity;

namespace GestionRestaurant.UCs
{
    public partial class UC_GT : UserControl
    {
        private DB db = new DB();
        private Table table = new Table();
        private int tableNum = 0;

        public UC_GT()
        {
            InitializeComponent();
        }
        public void réinitialiser()
        {
            NumPlaceTxtBox.Text = String.Empty;
            ErrLbl.Visible = false; 
        }

       public void selectTable()
        {
            tableDgv.DataSource = db.Tables.ToList();
            tableDgv.Columns["Affecter"].Visible = false;
            tableDgv.Columns["Commandees"].Visible = false;
        }

        public void createTable()
        {
            if (NumPlaceTxtBox.Text!= string.Empty)
            {


                table.nombre_places = Convert.ToInt16(NumPlaceTxtBox.Text);

                db.Tables.Add(table);
                db.SaveChanges();
                selectTable();  
                MessageBox.Show("enregistrement a été ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                réinitialiser();

            }
            else
            {
                if (NumPlaceTxtBox.Text == string.Empty) ErrLbl.Visible = true;
            }
        }

        public void deleteTabel(int numTable)
        {

            table = (Table) db.Tables.Where(x => x.numero_table == numTable).FirstOrDefault();

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Tables.Remove(table);
                db.SaveChanges();
                selectTable();
                MessageBox.Show("enregistrement a été supprimer");
                réinitialiser();
            }
            else réinitialiser();

        }

        public void updateTable()
        {
            table.nombre_places = Convert.ToInt32(NumPlaceTxtBox.Text);
            db.Entry(table).State = EntityState.Modified;
            db.SaveChanges();
            selectTable();
            MessageBox.Show("enregistrement a été Modifier", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            réinitialiser();
        }

        private void UC_GT_Load(object sender, EventArgs e)
        {
            réinitialiser();
            selectTable();
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            createTable();
        }

        private void modifBtn_Click(object sender, EventArgs e)
        {
            if (tableNum > 0)
            {
                updateTable();
            }
            else
            {
                MessageBox.Show("Double click pour Choisir une ligne de tablaux  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            if (tableNum > 0)
            {
                deleteTabel(tableNum);
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

        private void tableDgv_DoubleClick(object sender, EventArgs e)
        {
            if (tableDgv.CurrentCell.RowIndex != -1)
            {
                tableNum = Convert.ToInt32(tableDgv.CurrentRow.Cells["numero_table"].Value);
                table = db.Tables.Where(x => x.numero_table == tableNum).FirstOrDefault();
                NumPlaceTxtBox.Text = table.nombre_places.ToString();
                
            }
        }
    }
}
