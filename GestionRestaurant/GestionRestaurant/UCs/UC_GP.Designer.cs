namespace GestionRestaurant.UCs
{
    partial class UC_GP
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TyPlatTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ErrLbl3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrixTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrLbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AjoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.annulBtn = new Guna.UI2.WinForms.Guna2Button();
            this.suppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.modifBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LibelleTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.platDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.code_plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Page de Gestion des Plats";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(683, 481);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 99);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 38);
            this.label5.TabIndex = 23;
            this.label5.Text = "N.B: \r\nVous devez cliquer deux fois sur l’élément que vous souhaitez modifier ou " +
    "supprimer.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TyPlatTxtBox);
            this.panel1.Controls.Add(this.ErrLbl3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PrixTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ErrLbl2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ErrLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AjoutBtn);
            this.panel1.Controls.Add(this.annulBtn);
            this.panel1.Controls.Add(this.suppBtn);
            this.panel1.Controls.Add(this.modifBtn);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.LibelleTxtBox);
            this.panel1.Location = new System.Drawing.Point(-5, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 164);
            this.panel1.TabIndex = 22;
            // 
            // TyPlatTxtBox
            // 
            this.TyPlatTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.TyPlatTxtBox.BorderRadius = 5;
            this.TyPlatTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TyPlatTxtBox.DefaultText = "";
            this.TyPlatTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TyPlatTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TyPlatTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TyPlatTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TyPlatTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TyPlatTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyPlatTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TyPlatTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TyPlatTxtBox.Location = new System.Drawing.Point(398, 55);
            this.TyPlatTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TyPlatTxtBox.Name = "TyPlatTxtBox";
            this.TyPlatTxtBox.PasswordChar = '\0';
            this.TyPlatTxtBox.PlaceholderText = "";
            this.TyPlatTxtBox.SelectedText = "";
            this.TyPlatTxtBox.Size = new System.Drawing.Size(135, 29);
            this.TyPlatTxtBox.TabIndex = 12;
            // 
            // ErrLbl3
            // 
            this.ErrLbl3.AutoSize = true;
            this.ErrLbl3.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl3.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl3.Location = new System.Drawing.Point(659, 85);
            this.ErrLbl3.Name = "ErrLbl3";
            this.ErrLbl3.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl3.TabIndex = 11;
            this.ErrLbl3.Text = "Champ Obligatoire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prix (DH) :";
            // 
            // PrixTxtBox
            // 
            this.PrixTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.PrixTxtBox.BorderRadius = 5;
            this.PrixTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrixTxtBox.DefaultText = "";
            this.PrixTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrixTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrixTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrixTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrixTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PrixTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrixTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PrixTxtBox.Location = new System.Drawing.Point(616, 55);
            this.PrixTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrixTxtBox.Name = "PrixTxtBox";
            this.PrixTxtBox.PasswordChar = '\0';
            this.PrixTxtBox.PlaceholderText = "";
            this.PrixTxtBox.SelectedText = "";
            this.PrixTxtBox.Size = new System.Drawing.Size(135, 29);
            this.PrixTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Les informations du Plat";
            // 
            // ErrLbl2
            // 
            this.ErrLbl2.AutoSize = true;
            this.ErrLbl2.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl2.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl2.Location = new System.Drawing.Point(447, 85);
            this.ErrLbl2.Name = "ErrLbl2";
            this.ErrLbl2.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl2.TabIndex = 7;
            this.ErrLbl2.Text = "Champ Obligatoire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type Plat :";
            // 
            // ErrLbl
            // 
            this.ErrLbl.AutoSize = true;
            this.ErrLbl.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl.Location = new System.Drawing.Point(228, 85);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl.TabIndex = 4;
            this.ErrLbl.Text = "Champ Obligatoire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libelle :";
            // 
            // AjoutBtn
            // 
            this.AjoutBtn.BorderRadius = 5;
            this.AjoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AjoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AjoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AjoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AjoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AjoutBtn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutBtn.ForeColor = System.Drawing.Color.White;
            this.AjoutBtn.Location = new System.Drawing.Point(169, 118);
            this.AjoutBtn.Name = "AjoutBtn";
            this.AjoutBtn.Size = new System.Drawing.Size(109, 28);
            this.AjoutBtn.TabIndex = 2;
            this.AjoutBtn.Text = "Ajouter";
            this.AjoutBtn.Click += new System.EventHandler(this.AjoutBtn_Click);
            // 
            // annulBtn
            // 
            this.annulBtn.BorderRadius = 5;
            this.annulBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.annulBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.annulBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.annulBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.annulBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.annulBtn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulBtn.ForeColor = System.Drawing.Color.White;
            this.annulBtn.Location = new System.Drawing.Point(539, 118);
            this.annulBtn.Name = "annulBtn";
            this.annulBtn.Size = new System.Drawing.Size(109, 28);
            this.annulBtn.TabIndex = 2;
            this.annulBtn.Text = "Annuler";
            this.annulBtn.Click += new System.EventHandler(this.annulBtn_Click);
            // 
            // suppBtn
            // 
            this.suppBtn.BorderRadius = 5;
            this.suppBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.suppBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.suppBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.suppBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.suppBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.suppBtn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppBtn.ForeColor = System.Drawing.Color.White;
            this.suppBtn.Location = new System.Drawing.Point(414, 118);
            this.suppBtn.Name = "suppBtn";
            this.suppBtn.Size = new System.Drawing.Size(109, 28);
            this.suppBtn.TabIndex = 2;
            this.suppBtn.Text = "Supprimer";
            this.suppBtn.Click += new System.EventHandler(this.suppBtn_Click);
            // 
            // modifBtn
            // 
            this.modifBtn.BorderRadius = 5;
            this.modifBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.modifBtn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifBtn.ForeColor = System.Drawing.Color.White;
            this.modifBtn.Location = new System.Drawing.Point(289, 118);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(109, 28);
            this.modifBtn.TabIndex = 2;
            this.modifBtn.Text = "Modifier";
            this.modifBtn.Click += new System.EventHandler(this.modifBtn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(270, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = null;
            // 
            // LibelleTxtBox
            // 
            this.LibelleTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.LibelleTxtBox.BorderRadius = 5;
            this.LibelleTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibelleTxtBox.DefaultText = "";
            this.LibelleTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LibelleTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LibelleTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LibelleTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LibelleTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LibelleTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibelleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LibelleTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LibelleTxtBox.Location = new System.Drawing.Point(135, 55);
            this.LibelleTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibelleTxtBox.Name = "LibelleTxtBox";
            this.LibelleTxtBox.PasswordChar = '\0';
            this.LibelleTxtBox.PlaceholderText = "";
            this.LibelleTxtBox.SelectedText = "";
            this.LibelleTxtBox.Size = new System.Drawing.Size(185, 27);
            this.LibelleTxtBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.platDgv);
            this.panel2.Location = new System.Drawing.Point(122, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 214);
            this.panel2.TabIndex = 21;
            // 
            // platDgv
            // 
            this.platDgv.AllowUserToAddRows = false;
            this.platDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.platDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.platDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.platDgv.BackgroundColor = System.Drawing.Color.White;
            this.platDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.platDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.platDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.platDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.platDgv.ColumnHeadersHeight = 30;
            this.platDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.platDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_plat,
            this.libelle,
            this.type_plat,
            this.prix});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.platDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.platDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.platDgv.EnableHeadersVisualStyles = false;
            this.platDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.platDgv.Location = new System.Drawing.Point(0, 0);
            this.platDgv.Name = "platDgv";
            this.platDgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.platDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.platDgv.RowHeadersVisible = false;
            this.platDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.platDgv.RowTemplate.DividerHeight = 1;
            this.platDgv.RowTemplate.Height = 30;
            this.platDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.platDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.platDgv.Size = new System.Drawing.Size(551, 214);
            this.platDgv.TabIndex = 0;
            this.platDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.platDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.platDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.platDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.platDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.platDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.platDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.platDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.platDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.platDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.platDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.platDgv.ThemeStyle.HeaderStyle.Height = 30;
            this.platDgv.ThemeStyle.ReadOnly = true;
            this.platDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.platDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.platDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.platDgv.ThemeStyle.RowsStyle.Height = 30;
            this.platDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.platDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.platDgv.DoubleClick += new System.EventHandler(this.platDgv_DoubleClick);
            // 
            // code_plat
            // 
            this.code_plat.DataPropertyName = "code_plat";
            this.code_plat.HeaderText = "Code Plat";
            this.code_plat.Name = "code_plat";
            this.code_plat.ReadOnly = true;
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libelle";
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // type_plat
            // 
            this.type_plat.DataPropertyName = "type_plat";
            this.type_plat.HeaderText = "Type Plat";
            this.type_plat.Name = "type_plat";
            this.type_plat.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix (DH)";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.platDgv;
            // 
            // UC_GP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GP";
            this.Size = new System.Drawing.Size(794, 583);
            this.Load += new System.EventHandler(this.UC_GP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.platDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrLbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErrLbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AjoutBtn;
        private Guna.UI2.WinForms.Guna2Button annulBtn;
        private Guna.UI2.WinForms.Guna2Button suppBtn;
        private Guna.UI2.WinForms.Guna2Button modifBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox LibelleTxtBox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView platDgv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox PrixTxtBox;
        private System.Windows.Forms.Label ErrLbl3;
        private Guna.UI2.WinForms.Guna2TextBox TyPlatTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_plat;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_plat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}
