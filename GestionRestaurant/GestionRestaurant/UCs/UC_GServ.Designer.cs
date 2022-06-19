namespace GestionRestaurant.UCs
{
    partial class UC_GServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GServ));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serveurDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.numero_serveur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrLbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrenomTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ErrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AjoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.annulBtn = new Guna.UI2.WinForms.Guna2Button();
            this.suppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.modifBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NomTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serveurDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Serveurs";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.serveurDgv);
            this.panel2.Location = new System.Drawing.Point(122, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 214);
            this.panel2.TabIndex = 18;
            // 
            // serveurDgv
            // 
            this.serveurDgv.AllowUserToAddRows = false;
            this.serveurDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.serveurDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.serveurDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serveurDgv.BackgroundColor = System.Drawing.Color.White;
            this.serveurDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serveurDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serveurDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serveurDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.serveurDgv.ColumnHeadersHeight = 30;
            this.serveurDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.serveurDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_serveur,
            this.nom,
            this.prenom});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serveurDgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.serveurDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serveurDgv.EnableHeadersVisualStyles = false;
            this.serveurDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serveurDgv.Location = new System.Drawing.Point(0, 0);
            this.serveurDgv.Name = "serveurDgv";
            this.serveurDgv.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serveurDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.serveurDgv.RowHeadersVisible = false;
            this.serveurDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serveurDgv.RowTemplate.DividerHeight = 1;
            this.serveurDgv.RowTemplate.Height = 30;
            this.serveurDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serveurDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serveurDgv.Size = new System.Drawing.Size(551, 214);
            this.serveurDgv.TabIndex = 0;
            this.serveurDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.serveurDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.serveurDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.serveurDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.serveurDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.serveurDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.serveurDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serveurDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.serveurDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serveurDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveurDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serveurDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.serveurDgv.ThemeStyle.HeaderStyle.Height = 30;
            this.serveurDgv.ThemeStyle.ReadOnly = true;
            this.serveurDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.serveurDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serveurDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveurDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serveurDgv.ThemeStyle.RowsStyle.Height = 30;
            this.serveurDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serveurDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serveurDgv.DoubleClick += new System.EventHandler(this.serveurDgv_DoubleClick);
            // 
            // numero_serveur
            // 
            this.numero_serveur.DataPropertyName = "numero_serveur";
            this.numero_serveur.HeaderText = "N° Serveur";
            this.numero_serveur.Name = "numero_serveur";
            this.numero_serveur.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.serveurDgv;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ErrLbl2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PrenomTxtBox);
            this.panel1.Controls.Add(this.ErrLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AjoutBtn);
            this.panel1.Controls.Add(this.annulBtn);
            this.panel1.Controls.Add(this.suppBtn);
            this.panel1.Controls.Add(this.modifBtn);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.NomTxtBox);
            this.panel1.Location = new System.Drawing.Point(-5, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 164);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Les informations du Serveur";
            // 
            // ErrLbl2
            // 
            this.ErrLbl2.AutoSize = true;
            this.ErrLbl2.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl2.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl2.Location = new System.Drawing.Point(585, 85);
            this.ErrLbl2.Name = "ErrLbl2";
            this.ErrLbl2.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl2.TabIndex = 7;
            this.ErrLbl2.Text = "Champ Obligatoire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prénom : ";
            // 
            // PrenomTxtBox
            // 
            this.PrenomTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.PrenomTxtBox.BorderRadius = 5;
            this.PrenomTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrenomTxtBox.DefaultText = "";
            this.PrenomTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrenomTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrenomTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrenomTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrenomTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PrenomTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrenomTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PrenomTxtBox.Location = new System.Drawing.Point(469, 55);
            this.PrenomTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrenomTxtBox.Name = "PrenomTxtBox";
            this.PrenomTxtBox.PasswordChar = '\0';
            this.PrenomTxtBox.PlaceholderText = "";
            this.PrenomTxtBox.SelectedText = "";
            this.PrenomTxtBox.Size = new System.Drawing.Size(208, 29);
            this.PrenomTxtBox.TabIndex = 5;
            // 
            // ErrLbl
            // 
            this.ErrLbl.AutoSize = true;
            this.ErrLbl.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl.Location = new System.Drawing.Point(289, 85);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl.TabIndex = 4;
            this.ErrLbl.Text = "Champ Obligatoire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom : ";
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
            this.AjoutBtn.Location = new System.Drawing.Point(157, 118);
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
            this.annulBtn.Location = new System.Drawing.Point(527, 118);
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
            this.suppBtn.Location = new System.Drawing.Point(402, 118);
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
            this.modifBtn.Location = new System.Drawing.Point(277, 118);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(109, 28);
            this.modifBtn.TabIndex = 2;
            this.modifBtn.Text = "Modifier";
            this.modifBtn.Click += new System.EventHandler(this.modifBtn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(225, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = null;
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.NomTxtBox.BorderRadius = 5;
            this.NomTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomTxtBox.DefaultText = "";
            this.NomTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NomTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NomTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NomTxtBox.Location = new System.Drawing.Point(196, 55);
            this.NomTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.PasswordChar = '\0';
            this.NomTxtBox.PlaceholderText = "";
            this.NomTxtBox.SelectedText = "";
            this.NomTxtBox.Size = new System.Drawing.Size(185, 27);
            this.NomTxtBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 38);
            this.label5.TabIndex = 20;
            this.label5.Text = "N.B: \r\nVous devez cliquer deux fois sur l’élément que vous souhaitez modifier ou " +
    "supprimer.";
            // 
            // UC_GServ
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
            this.Name = "UC_GServ";
            this.Size = new System.Drawing.Size(794, 583);
            this.Load += new System.EventHandler(this.UC_GServ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serveurDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView serveurDgv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrLbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AjoutBtn;
        private Guna.UI2.WinForms.Guna2Button annulBtn;
        private Guna.UI2.WinForms.Guna2Button suppBtn;
        private Guna.UI2.WinForms.Guna2Button modifBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox NomTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_serveur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.Label ErrLbl2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PrenomTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
