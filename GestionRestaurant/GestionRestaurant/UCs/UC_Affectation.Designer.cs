namespace GestionRestaurant.UCs
{
    partial class UC_Affectation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Affectation));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTableComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numServComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrLbl2 = new System.Windows.Forms.Label();
            this.ErrLbl = new System.Windows.Forms.Label();
            this.AffBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.affectationDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.numero_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_serveur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_affectation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affectationDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Affectation des Serveurs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 38);
            this.label5.TabIndex = 23;
            this.label5.Text = "N.B: \r\nVous devez cliquer deux fois sur l’élément que vous souhaitez modifier ou " +
    "supprimer.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numTableComBox);
            this.panel1.Controls.Add(this.numServComBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ErrLbl2);
            this.panel1.Controls.Add(this.ErrLbl);
            this.panel1.Controls.Add(this.AffBtn);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Location = new System.Drawing.Point(-5, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 164);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Serveur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "N° Table : ";
            // 
            // numTableComBox
            // 
            this.numTableComBox.BackColor = System.Drawing.Color.Transparent;
            this.numTableComBox.BorderColor = System.Drawing.Color.Black;
            this.numTableComBox.BorderRadius = 7;
            this.numTableComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numTableComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numTableComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.numTableComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.numTableComBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTableComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.numTableComBox.ItemHeight = 30;
            this.numTableComBox.Location = new System.Drawing.Point(252, 50);
            this.numTableComBox.Name = "numTableComBox";
            this.numTableComBox.Size = new System.Drawing.Size(143, 36);
            this.numTableComBox.TabIndex = 13;
            this.numTableComBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTableComBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // numServComBox
            // 
            this.numServComBox.BackColor = System.Drawing.Color.Transparent;
            this.numServComBox.BorderColor = System.Drawing.Color.Black;
            this.numServComBox.BorderRadius = 7;
            this.numServComBox.DisplayMember = "hello";
            this.numServComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numServComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numServComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.numServComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.numServComBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numServComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.numServComBox.ItemHeight = 30;
            this.numServComBox.Location = new System.Drawing.Point(469, 50);
            this.numServComBox.Name = "numServComBox";
            this.numServComBox.Size = new System.Drawing.Size(174, 36);
            this.numServComBox.TabIndex = 10;
            this.numServComBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServComBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.numServComBox.ValueMember = "hekkke";
            this.numServComBox.SelectedIndexChanged += new System.EventHandler(this.numServComBox_SelectedIndexChanged);
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
            this.ErrLbl2.Location = new System.Drawing.Point(551, 89);
            this.ErrLbl2.Name = "ErrLbl2";
            this.ErrLbl2.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl2.TabIndex = 7;
            this.ErrLbl2.Text = "Champ Obligatoire";
            // 
            // ErrLbl
            // 
            this.ErrLbl.AutoSize = true;
            this.ErrLbl.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl.Location = new System.Drawing.Point(286, 89);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl.TabIndex = 4;
            this.ErrLbl.Text = "Champ Obligatoire";
            // 
            // AffBtn
            // 
            this.AffBtn.BorderRadius = 5;
            this.AffBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AffBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AffBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AffBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AffBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AffBtn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffBtn.ForeColor = System.Drawing.Color.White;
            this.AffBtn.Location = new System.Drawing.Point(334, 131);
            this.AffBtn.Name = "AffBtn";
            this.AffBtn.Size = new System.Drawing.Size(148, 28);
            this.AffBtn.TabIndex = 2;
            this.AffBtn.Text = "Affecter";
            this.AffBtn.Click += new System.EventHandler(this.AjoutBtn_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.affectationDgv);
            this.panel2.Location = new System.Drawing.Point(115, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 214);
            this.panel2.TabIndex = 21;
            // 
            // affectationDgv
            // 
            this.affectationDgv.AllowUserToAddRows = false;
            this.affectationDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.affectationDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.affectationDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.affectationDgv.BackgroundColor = System.Drawing.Color.White;
            this.affectationDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.affectationDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.affectationDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.affectationDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.affectationDgv.ColumnHeadersHeight = 40;
            this.affectationDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.affectationDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_table,
            this.numero_serveur,
            this.nom,
            this.prenom,
            this.date_affectation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.affectationDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.affectationDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.affectationDgv.EnableHeadersVisualStyles = false;
            this.affectationDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.affectationDgv.Location = new System.Drawing.Point(0, 0);
            this.affectationDgv.Name = "affectationDgv";
            this.affectationDgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.affectationDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.affectationDgv.RowHeadersVisible = false;
            this.affectationDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.affectationDgv.RowTemplate.DividerHeight = 1;
            this.affectationDgv.RowTemplate.Height = 30;
            this.affectationDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.affectationDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectationDgv.Size = new System.Drawing.Size(551, 214);
            this.affectationDgv.TabIndex = 0;
            this.affectationDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.affectationDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.affectationDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.affectationDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.affectationDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.affectationDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.affectationDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.affectationDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.affectationDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.affectationDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affectationDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.affectationDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.affectationDgv.ThemeStyle.HeaderStyle.Height = 40;
            this.affectationDgv.ThemeStyle.ReadOnly = true;
            this.affectationDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.affectationDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.affectationDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affectationDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.affectationDgv.ThemeStyle.RowsStyle.Height = 30;
            this.affectationDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.affectationDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // numero_table
            // 
            this.numero_table.DataPropertyName = "numero_table";
            this.numero_table.HeaderText = " N° Table";
            this.numero_table.Name = "numero_table";
            this.numero_table.ReadOnly = true;
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
            this.nom.HeaderText = "Nom Serveur";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prenom Serveur";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // date_affectation
            // 
            this.date_affectation.DataPropertyName = "date_affectation";
            this.date_affectation.HeaderText = "Date d\'Affectation";
            this.date_affectation.Name = "date_affectation";
            this.date_affectation.ReadOnly = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(683, 481);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 99);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.affectationDgv;
            // 
            // UC_Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Affectation";
            this.Size = new System.Drawing.Size(794, 583);
            this.Load += new System.EventHandler(this.UC_Affectation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.affectationDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrLbl2;
        private System.Windows.Forms.Label ErrLbl;
        private Guna.UI2.WinForms.Guna2Button AffBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView affectationDgv;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ComboBox numServComBox;
        public Guna.UI2.WinForms.Guna2ComboBox numTableComBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_serveur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_affectation;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
