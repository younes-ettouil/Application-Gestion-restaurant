using GestionRestaurant.UCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Acc uc = new UC_Acc();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void accueilBtn_Click(object sender, EventArgs e)
        {
            UC_Acc uc = new UC_Acc();
            addUserControl(uc);
        }

        private void GTableBtn_Click(object sender, EventArgs e)
        {
            UC_GT uc = new UC_GT();
            addUserControl(uc);
        }

        private void GPlatBtn_Click(object sender, EventArgs e)
        {
            UC_GP uc = new UC_GP();
            addUserControl(uc);
        }

        private void GServBtn_Click(object sender, EventArgs e)
        {
            UC_GServ uc = new UC_GServ();
            addUserControl(uc);
        }

        private void AffectServBtn_Click(object sender, EventArgs e)
        {
            UC_Affectation uc = new UC_Affectation();
            addUserControl(uc);
        }

        private void GCmdBtn_Click(object sender, EventArgs e)
        {
            UC_Commandes uc = new UC_Commandes();
            addUserControl(uc);
        }

        private void FactureBtn_Click(object sender, EventArgs e)
        {
            UC_BTNFACTURE uc = new UC_BTNFACTURE();
            addUserControl(uc);
        }
    }
}
