using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.UCs;
namespace GestionRestaurant.UCs
{
    public partial class UC_Facture : UserControl
    {
        public string date_cmd { get; set; }
        public int numCommande { get; set; }
        public int numTable { get; set; }
        public int nbr_pers { get; set; }
        public string plat { get; set; }
        public double prix { get; set; }
        public int qte { get; set; }
        public string heur_paie { get; set; }
        public string mode_paie { get; set; }


        public UC_Facture()
        {
            InitializeComponent();
        }

        public double Totale(double prix,int qte)
        {
            return prix * qte;
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            conPnl.Controls.Clear();
            conPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void UC_Facture_Load(object sender, EventArgs e)
        {
            LabelNumTable.Text = numTable.ToString();
            NumCommandeLabel.Text = numCommande.ToString(); 
            nombrePersLabel.Text = nbr_pers.ToString();
            DateLabel.Text = date_cmd.ToString();
            Prixlabel.Text = prix.ToString();   
            PlatLabel.Text = plat.ToString();
            QteLabel.Text = qte.ToString(); 
            ModePaieLabel.Text = mode_paie.ToString();  
            HeurePaieLabel.Text = heur_paie.ToString();
            TotalLabel.Text = Totale(prix,qte).ToString();

        }

        

        private void reteurBtn_Click(object sender, EventArgs e)
        {
            UC_Commandes uc = new UC_Commandes();
            addUserControl(uc); 
            
        }

        private void conPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
