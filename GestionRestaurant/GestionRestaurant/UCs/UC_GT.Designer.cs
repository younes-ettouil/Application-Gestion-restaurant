namespace GestionRestaurant.UCs
{
    partial class UC_GT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AjoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.annulBtn = new Guna.UI2.WinForms.Guna2Button();
            this.suppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.modifBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NumPlaceTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.numero_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page de Gestion des Tables";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(683, 481);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 99);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ErrLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AjoutBtn);
            this.panel1.Controls.Add(this.annulBtn);
            this.panel1.Controls.Add(this.suppBtn);
            this.panel1.Controls.Add(this.modifBtn);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.NumPlaceTxtBox);
            this.panel1.Location = new System.Drawing.Point(-5, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 164);
            this.panel1.TabIndex = 15;
            // 
            // ErrLbl
            // 
            this.ErrLbl.AutoSize = true;
            this.ErrLbl.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrLbl.Location = new System.Drawing.Point(519, 62);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(92, 14);
            this.ErrLbl.TabIndex = 4;
            this.ErrLbl.Text = "Champ Obligatoire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Places de Table";
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(248, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = null;
            // 
            // NumPlaceTxtBox
            // 
            this.NumPlaceTxtBox.AutoScroll = true;
            this.NumPlaceTxtBox.BorderColor = System.Drawing.Color.DimGray;
            this.NumPlaceTxtBox.BorderRadius = 5;
            this.NumPlaceTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumPlaceTxtBox.DefaultText = "";
            this.NumPlaceTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumPlaceTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumPlaceTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumPlaceTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumPlaceTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NumPlaceTxtBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPlaceTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumPlaceTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NumPlaceTxtBox.Location = new System.Drawing.Point(328, 55);
            this.NumPlaceTxtBox.Name = "NumPlaceTxtBox";
            this.NumPlaceTxtBox.PasswordChar = '\0';
            this.NumPlaceTxtBox.PlaceholderText = "";
            this.NumPlaceTxtBox.SelectedText = "";
            this.NumPlaceTxtBox.Size = new System.Drawing.Size(185, 27);
            this.NumPlaceTxtBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableDgv);
            this.panel2.Location = new System.Drawing.Point(122, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 214);
            this.panel2.TabIndex = 17;
            // 
            // tableDgv
            // 
            this.tableDgv.AllowUserToAddRows = false;
            this.tableDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.tableDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.tableDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDgv.BackgroundColor = System.Drawing.Color.White;
            this.tableDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.tableDgv.ColumnHeadersHeight = 30;
            this.tableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_table,
            this.nombre_places});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDgv.DefaultCellStyle = dataGridViewCellStyle27;
            this.tableDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDgv.EnableHeadersVisualStyles = false;
            this.tableDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDgv.Location = new System.Drawing.Point(0, 0);
            this.tableDgv.Name = "tableDgv";
            this.tableDgv.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.tableDgv.RowHeadersVisible = false;
            this.tableDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableDgv.RowTemplate.DividerHeight = 1;
            this.tableDgv.RowTemplate.Height = 30;
            this.tableDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDgv.Size = new System.Drawing.Size(551, 214);
            this.tableDgv.TabIndex = 0;
            this.tableDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.tableDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableDgv.ThemeStyle.HeaderStyle.Height = 30;
            this.tableDgv.ThemeStyle.ReadOnly = true;
            this.tableDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableDgv.ThemeStyle.RowsStyle.Height = 30;
            this.tableDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableDgv.DoubleClick += new System.EventHandler(this.tableDgv_DoubleClick);
            // 
            // numero_table
            // 
            this.numero_table.DataPropertyName = "numero_table";
            this.numero_table.HeaderText = "N° Table";
            this.numero_table.Name = "numero_table";
            this.numero_table.ReadOnly = true;
            // 
            // nombre_places
            // 
            this.nombre_places.DataPropertyName = "nombre_places";
            this.nombre_places.HeaderText = "N° Places";
            this.nombre_places.Name = "nombre_places";
            this.nombre_places.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.tableDgv;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Les informations de la table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "N.B: \r\nVous devez cliquer deux fois sur l’élément que vous souhaitez modifier ou " +
    "supprimer.";
            // 
            // UC_GT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GT";
            this.Size = new System.Drawing.Size(794, 583);
            this.Load += new System.EventHandler(this.UC_GT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox NumPlaceTxtBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AjoutBtn;
        private Guna.UI2.WinForms.Guna2Button annulBtn;
        private Guna.UI2.WinForms.Guna2Button suppBtn;
        private Guna.UI2.WinForms.Guna2Button modifBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView tableDgv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_places;
        private System.Windows.Forms.Label ErrLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
