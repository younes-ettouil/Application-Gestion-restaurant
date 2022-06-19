namespace GestionRestaurant
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.accueilBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GTableBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GPlatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GServBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AffectServBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GCmdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FactureBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 583);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 147);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel2.Controls.Add(this.accueilBtn);
            this.flowLayoutPanel2.Controls.Add(this.GTableBtn);
            this.flowLayoutPanel2.Controls.Add(this.GPlatBtn);
            this.flowLayoutPanel2.Controls.Add(this.GServBtn);
            this.flowLayoutPanel2.Controls.Add(this.AffectServBtn);
            this.flowLayoutPanel2.Controls.Add(this.GCmdBtn);
            this.flowLayoutPanel2.Controls.Add(this.FactureBtn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 156);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 427);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // accueilBtn
            // 
            this.accueilBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.accueilBtn.Checked = true;
            this.accueilBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.accueilBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.accueilBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.accueilBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accueilBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accueilBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accueilBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accueilBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.accueilBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilBtn.ForeColor = System.Drawing.Color.White;
            this.accueilBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.accueilBtn.Image = ((System.Drawing.Image)(resources.GetObject("accueilBtn.Image")));
            this.accueilBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accueilBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.accueilBtn.Location = new System.Drawing.Point(3, 3);
            this.accueilBtn.Name = "accueilBtn";
            this.accueilBtn.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.accueilBtn.Size = new System.Drawing.Size(217, 47);
            this.accueilBtn.TabIndex = 3;
            this.accueilBtn.Text = "Accueil";
            this.accueilBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accueilBtn.Click += new System.EventHandler(this.accueilBtn_Click);
            // 
            // GTableBtn
            // 
            this.GTableBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GTableBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.GTableBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GTableBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GTableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GTableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GTableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GTableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GTableBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GTableBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTableBtn.ForeColor = System.Drawing.Color.White;
            this.GTableBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.GTableBtn.Image = ((System.Drawing.Image)(resources.GetObject("GTableBtn.Image")));
            this.GTableBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GTableBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.GTableBtn.Location = new System.Drawing.Point(3, 56);
            this.GTableBtn.Name = "GTableBtn";
            this.GTableBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.GTableBtn.Size = new System.Drawing.Size(217, 47);
            this.GTableBtn.TabIndex = 3;
            this.GTableBtn.Text = "Gestion des Tables";
            this.GTableBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GTableBtn.Click += new System.EventHandler(this.GTableBtn_Click);
            // 
            // GPlatBtn
            // 
            this.GPlatBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GPlatBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.GPlatBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GPlatBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GPlatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GPlatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GPlatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GPlatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GPlatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GPlatBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPlatBtn.ForeColor = System.Drawing.Color.White;
            this.GPlatBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.GPlatBtn.Image = ((System.Drawing.Image)(resources.GetObject("GPlatBtn.Image")));
            this.GPlatBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GPlatBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.GPlatBtn.Location = new System.Drawing.Point(3, 109);
            this.GPlatBtn.Name = "GPlatBtn";
            this.GPlatBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.GPlatBtn.Size = new System.Drawing.Size(217, 47);
            this.GPlatBtn.TabIndex = 3;
            this.GPlatBtn.Text = "Gestion des Plats";
            this.GPlatBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GPlatBtn.Click += new System.EventHandler(this.GPlatBtn_Click);
            // 
            // GServBtn
            // 
            this.GServBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GServBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.GServBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GServBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GServBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GServBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GServBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GServBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GServBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GServBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GServBtn.ForeColor = System.Drawing.Color.White;
            this.GServBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.GServBtn.Image = ((System.Drawing.Image)(resources.GetObject("GServBtn.Image")));
            this.GServBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GServBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.GServBtn.Location = new System.Drawing.Point(3, 162);
            this.GServBtn.Name = "GServBtn";
            this.GServBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.GServBtn.Size = new System.Drawing.Size(217, 47);
            this.GServBtn.TabIndex = 3;
            this.GServBtn.Text = "Gestion des Serveur";
            this.GServBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GServBtn.Click += new System.EventHandler(this.GServBtn_Click);
            // 
            // AffectServBtn
            // 
            this.AffectServBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AffectServBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.AffectServBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AffectServBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.AffectServBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AffectServBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AffectServBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AffectServBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AffectServBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AffectServBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffectServBtn.ForeColor = System.Drawing.Color.White;
            this.AffectServBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.AffectServBtn.Image = ((System.Drawing.Image)(resources.GetObject("AffectServBtn.Image")));
            this.AffectServBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AffectServBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.AffectServBtn.Location = new System.Drawing.Point(3, 215);
            this.AffectServBtn.Name = "AffectServBtn";
            this.AffectServBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.AffectServBtn.Size = new System.Drawing.Size(217, 47);
            this.AffectServBtn.TabIndex = 4;
            this.AffectServBtn.Text = "Affectation des Serveur";
            this.AffectServBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AffectServBtn.Click += new System.EventHandler(this.AffectServBtn_Click);
            // 
            // GCmdBtn
            // 
            this.GCmdBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GCmdBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.GCmdBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GCmdBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GCmdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GCmdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GCmdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GCmdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GCmdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.GCmdBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCmdBtn.ForeColor = System.Drawing.Color.White;
            this.GCmdBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.GCmdBtn.Image = ((System.Drawing.Image)(resources.GetObject("GCmdBtn.Image")));
            this.GCmdBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GCmdBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.GCmdBtn.Location = new System.Drawing.Point(3, 268);
            this.GCmdBtn.Name = "GCmdBtn";
            this.GCmdBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.GCmdBtn.Size = new System.Drawing.Size(217, 47);
            this.GCmdBtn.TabIndex = 4;
            this.GCmdBtn.Text = "Gestion des Commandes";
            this.GCmdBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GCmdBtn.Click += new System.EventHandler(this.GCmdBtn_Click);
            // 
            // FactureBtn
            // 
            this.FactureBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.FactureBtn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.FactureBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.FactureBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.FactureBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FactureBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FactureBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FactureBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FactureBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.FactureBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactureBtn.ForeColor = System.Drawing.Color.White;
            this.FactureBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.FactureBtn.Image = ((System.Drawing.Image)(resources.GetObject("FactureBtn.Image")));
            this.FactureBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FactureBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.FactureBtn.Location = new System.Drawing.Point(3, 321);
            this.FactureBtn.Name = "FactureBtn";
            this.FactureBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.FactureBtn.Size = new System.Drawing.Size(217, 47);
            this.FactureBtn.TabIndex = 4;
            this.FactureBtn.Text = "Facture ";
            this.FactureBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FactureBtn.Click += new System.EventHandler(this.FactureBtn_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.ForeColor = System.Drawing.Color.Black;
            this.ContainerPanel.Location = new System.Drawing.Point(230, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(801, 583);
            this.ContainerPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 583);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d’un restaurant ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button GTableBtn;
        private Guna.UI2.WinForms.Guna2Button accueilBtn;
        private Guna.UI2.WinForms.Guna2Button GPlatBtn;
        private Guna.UI2.WinForms.Guna2Button GServBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel ContainerPanel;
        private Guna.UI2.WinForms.Guna2Button AffectServBtn;
        private Guna.UI2.WinForms.Guna2Button GCmdBtn;
        private Guna.UI2.WinForms.Guna2Button FactureBtn;
    }
}

