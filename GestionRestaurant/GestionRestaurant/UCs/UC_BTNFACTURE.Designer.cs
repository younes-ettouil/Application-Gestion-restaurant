﻿namespace GestionRestaurant.UCs
{
    partial class UC_BTNFACTURE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BTNFACTURE));
            this.PanelContainer3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmdDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.numero_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_personnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure_paiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode_paiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PanelContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer3
            // 
            this.PanelContainer3.Controls.Add(this.label2);
            this.PanelContainer3.Controls.Add(this.panel2);
            this.PanelContainer3.Controls.Add(this.pictureBox3);
            this.PanelContainer3.Controls.Add(this.pictureBox1);
            this.PanelContainer3.Controls.Add(this.pictureBox5);
            this.PanelContainer3.Controls.Add(this.pictureBox2);
            this.PanelContainer3.Controls.Add(this.pictureBox4);
            this.PanelContainer3.Controls.Add(this.pictureBox6);
            this.PanelContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer3.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer3.Name = "PanelContainer3";
            this.PanelContainer3.Size = new System.Drawing.Size(794, 583);
            this.PanelContainer3.TabIndex = 0;
            this.PanelContainer3.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContainer3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Factures";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CmdDgv);
            this.panel2.Location = new System.Drawing.Point(21, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 471);
            this.panel2.TabIndex = 33;
            // 
            // CmdDgv
            // 
            this.CmdDgv.AllowUserToAddRows = false;
            this.CmdDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CmdDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CmdDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CmdDgv.BackgroundColor = System.Drawing.Color.White;
            this.CmdDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CmdDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CmdDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CmdDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CmdDgv.ColumnHeadersHeight = 38;
            this.CmdDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CmdDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_cmd,
            this.num_table,
            this.nombre_personnes,
            this.date_cmd,
            this.heure_paiement,
            this.mode_paiement,
            this.plat,
            this.quantite,
            this.prix});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CmdDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.CmdDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdDgv.EnableHeadersVisualStyles = false;
            this.CmdDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CmdDgv.Location = new System.Drawing.Point(0, 0);
            this.CmdDgv.Name = "CmdDgv";
            this.CmdDgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CmdDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CmdDgv.RowHeadersVisible = false;
            this.CmdDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CmdDgv.RowTemplate.DividerHeight = 1;
            this.CmdDgv.RowTemplate.Height = 30;
            this.CmdDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CmdDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CmdDgv.Size = new System.Drawing.Size(753, 471);
            this.CmdDgv.TabIndex = 0;
            this.CmdDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CmdDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CmdDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CmdDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CmdDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CmdDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CmdDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CmdDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CmdDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CmdDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CmdDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CmdDgv.ThemeStyle.HeaderStyle.Height = 38;
            this.CmdDgv.ThemeStyle.ReadOnly = true;
            this.CmdDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CmdDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CmdDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CmdDgv.ThemeStyle.RowsStyle.Height = 30;
            this.CmdDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CmdDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // numero_cmd
            // 
            this.numero_cmd.DataPropertyName = "numero_cmd";
            this.numero_cmd.HeaderText = "N° Commande";
            this.numero_cmd.Name = "numero_cmd";
            this.numero_cmd.ReadOnly = true;
            // 
            // num_table
            // 
            this.num_table.DataPropertyName = "num_table";
            this.num_table.HeaderText = "N° Table";
            this.num_table.Name = "num_table";
            this.num_table.ReadOnly = true;
            // 
            // nombre_personnes
            // 
            this.nombre_personnes.DataPropertyName = "nombre_personnes";
            this.nombre_personnes.HeaderText = "Nombre Personnes";
            this.nombre_personnes.Name = "nombre_personnes";
            this.nombre_personnes.ReadOnly = true;
            // 
            // date_cmd
            // 
            this.date_cmd.DataPropertyName = "date_cmd";
            this.date_cmd.HeaderText = "Date";
            this.date_cmd.Name = "date_cmd";
            this.date_cmd.ReadOnly = true;
            // 
            // heure_paiement
            // 
            this.heure_paiement.DataPropertyName = "heure_paiement";
            this.heure_paiement.HeaderText = "Heure Paiement";
            this.heure_paiement.Name = "heure_paiement";
            this.heure_paiement.ReadOnly = true;
            // 
            // mode_paiement
            // 
            this.mode_paiement.DataPropertyName = "mode_paiement";
            this.mode_paiement.HeaderText = "Mode Paiement";
            this.mode_paiement.Name = "mode_paiement";
            this.mode_paiement.ReadOnly = true;
            // 
            // plat
            // 
            this.plat.DataPropertyName = "libelle";
            this.plat.HeaderText = "Plat";
            this.plat.Name = "plat";
            this.plat.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(714, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.CmdDgv;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(708, 509);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(352, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(61, 511);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(485, -31);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(86, 102);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // UC_BTNFACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainer3);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_BTNFACTURE";
            this.Size = new System.Drawing.Size(794, 583);
            this.Load += new System.EventHandler(this.UC_BTNFACTURE_Load);
            this.PanelContainer3.ResumeLayout(false);
            this.PanelContainer3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmdDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContainer3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView CmdDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_personnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure_paiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode_paiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn plat;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
