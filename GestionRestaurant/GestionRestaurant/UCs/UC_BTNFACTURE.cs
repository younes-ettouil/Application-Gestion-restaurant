using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Data;


namespace GestionRestaurant.UCs
{
    public partial class UC_BTNFACTURE : UserControl
    {
        DB db = new DB();
        public UC_BTNFACTURE()
        {
            InitializeComponent();
        }

        private void UC_BTNFACTURE_Load(object sender, EventArgs e)
        {
            selectCommandes();
        }

        public void selectCommandes()
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
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer3.Controls.Clear();
            PanelContainer3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void PanelContainer3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
