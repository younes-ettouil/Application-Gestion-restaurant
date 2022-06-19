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
    public partial class UC_Commandes : UserControl
    {
        private DB db = new DB();
        private Commande cmd = new Commande();
        private Contient contient = new Contient();
        private int idCmd = 0;
        public UC_Commandes()
        {
            InitializeComponent();
            chargerComBoxs();
            
        }

        public void chargerComBoxs()
        {


            numTableComBox.DataSource = db.Tables.Select(x => x.numero_table).ToList();
            numTableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlatsComboBox.DataSource = db.Plats.Select(x => x.code_plat+":"+x.libelle).ToList();
            PlatsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void réinitialiser()
        {
            numTableComBox.SelectedIndex = 0;
            ModePaiementCombox.SelectedIndex = 0;
            NbPersTxtBox.Text = String.Empty;
            PlatsComboBox.SelectedIndex = 0;
            QteTxtBox.Text = string.Empty;
            ErrLbl.Visible = false;
            ErrLbl2.Visible = false;
            ErrLbl3.Visible = false;
            ErrLbl4.Visible = false;
            ErrLbl5.Visible = false;

        }

        public void  selectCommandes()
        {
            DataGridViewButtonColumn FactureBtnCol = new DataGridViewButtonColumn();
            /* CmdDgv.Columns.Add(FactureBtnCol);
             FactureBtnCol.HeaderText = "Click Data";
             FactureBtnCol.Text = "Click Here";
             FactureBtnCol.Name = "btn";
            */
            //FactureBtnCol.BorderRadius = 5;
         
          
            

            FactureBtnCol.Name = "Facture";
            FactureBtnCol.Text = "Facture";
            FactureBtnCol.FlatStyle = FlatStyle.Flat;
            FactureBtnCol.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            FactureBtnCol.DefaultCellStyle.SelectionForeColor = Color.White;
            

            int columnIndex = 8;
            if (CmdDgv.Columns["Facture"] == null)
            {
                
                CmdDgv.Columns.Insert(columnIndex, FactureBtnCol);
            }
            FactureBtnCol.UseColumnTextForButtonValue = true;
            CmdDgv.CellClick += CmdDgv_CellClick;
            /*CmdDgv.DataSource = db.Commandes.ToList();*/
            CmdDgv.DataSource = (from cmds in db.Commandes
                                         select new
                                         {
                                             cmds.numero_cmd,
                                             cmds.num_table,
                                             cmds.nombre_personnes,
                                             cmds.date_cmd,
                                             cmds.heure_paiement,
                                             cmds.mode_paiement,
                                             cmds.Contient.Plat.libelle,
                                             cmds.Contient.Plat.prix,
                                             cmds.Contient.quantite,


                                         }).ToList();
            CmdDgv.Refresh();

            /*CmdDgv.Columns["Table"].Visible = false;*/
        }
        
        public void createCmdPlats()
        {
            contient.code_plat = Convert.ToInt32(PlatsComboBox.Text.Substring(0, 1));
            contient.num_cmd = idCmd;
            contient.quantite = Convert.ToInt32(QteTxtBox.Text);
            db.Contients.Add(contient); 
            db.SaveChanges();
            selectCommandes();
            réinitialiser();
            MessageBox.Show("enregistrement : a été ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void createCommande()
        {

            if (numTableComBox.Text != string.Empty && NbPersTxtBox.Text != string.Empty && ModePaiementCombox.Text !=string.Empty)
            {


                cmd.num_table = Convert.ToInt32(numTableComBox.Text);
                cmd.nombre_personnes = Convert.ToInt32(NbPersTxtBox.Text);
                string date = DateTime.Now.ToString("MM-dd-yyyy");
                cmd.date_cmd = date;
                string heure = DateTime.Now.ToString("HH:mm:ss");
                cmd.heure_paiement = heure;
                cmd.mode_paiement = ModePaiementCombox.Text;


                db.Commandes.Add(cmd);
                db.SaveChanges();
                
                
                idCmd = cmd.numero_cmd;
              

            }
            else
            {
                if (numTableComBox.Text == string.Empty) ErrLbl.Visible = true;
                if (NbPersTxtBox.Text == string.Empty) ErrLbl2.Visible = true;
                if (ModePaiementCombox.Text == string.Empty) ErrLbl3.Visible = true;

            }
        }



        private void UC_Commandes_Load(object sender, EventArgs e)
        {
            réinitialiser();
            selectCommandes();
        }

      

        private void PlatsComboBox_Click(object sender, EventArgs e)
        {
            createCommande();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Clear();
            PanelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }

       
        private void CmdDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CmdDgv.Columns["Facture"].Index)
            {
                UC_Facture ucf = new UC_Facture();
                ucf.date_cmd = Convert.ToString(CmdDgv.CurrentRow.Cells["date_cmd"].Value);
                ucf.numCommande = Convert.ToInt32(CmdDgv.CurrentRow.Cells["numero_cmd"].Value);
                ucf.numTable = Convert.ToInt32(CmdDgv.CurrentRow.Cells["num_table"].Value);
                ucf.nbr_pers = Convert.ToInt32(CmdDgv.CurrentRow.Cells["nombre_personnes"].Value);
                ucf.prix = Convert.ToDouble(CmdDgv.CurrentRow.Cells["prix"].Value);
                ucf.qte = Convert.ToInt32(CmdDgv.CurrentRow.Cells["quantite"].Value);
                ucf.heur_paie = Convert.ToString(CmdDgv.CurrentRow.Cells["heure_paiement"].Value);
                ucf.mode_paie = Convert.ToString(CmdDgv.CurrentRow.Cells["mode_paiement"].Value);
                ucf.plat = Convert.ToString(CmdDgv.CurrentRow.Cells["plat"].Value);
                addUserControl(ucf);

            }
        }

       
        private void CmdBtn_Click(object sender, EventArgs e)
        {
            createCmdPlats();
        }

        private void PanelContainer2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
