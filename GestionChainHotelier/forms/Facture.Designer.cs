﻿
namespace GestionHotel.forms
{
    partial class Facture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.label11 = new System.Windows.Forms.Label();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.TextDateRes = new System.Windows.Forms.TextBox();
            this.textDateArrhes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDateFin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDateDebut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextFacture = new System.Windows.Forms.RichTextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(51, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Date début";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPrenom.Location = new System.Drawing.Point(267, 162);
            this.BoxPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxPrenom.Multiline = true;
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(220, 36);
            this.BoxPrenom.TabIndex = 36;
            this.BoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(51, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "CIN où Passport";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoxNom
            // 
            this.BoxNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNom.Location = new System.Drawing.Point(267, 105);
            this.BoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxNom.Multiline = true;
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(220, 36);
            this.BoxNom.TabIndex = 34;
            this.BoxNom.TabStop = false;
            this.BoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(51, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nom et Prénom";
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(391, 37);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(299, 36);
            this.textSearch.TabIndex = 58;
            this.textSearch.TabStop = false;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(100, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 25);
            this.label12.TabIndex = 57;
            this.label12.Text = "Numéro de réservation      :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(698, 37);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(142, 36);
            this.buttonSearch.TabIndex = 59;
            this.buttonSearch.Text = "Chercher";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // TextDateRes
            // 
            this.TextDateRes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextDateRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDateRes.Location = new System.Drawing.Point(267, 218);
            this.TextDateRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextDateRes.Multiline = true;
            this.TextDateRes.Name = "TextDateRes";
            this.TextDateRes.Size = new System.Drawing.Size(220, 36);
            this.TextDateRes.TabIndex = 60;
            this.TextDateRes.TabStop = false;
            this.TextDateRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDateArrhes
            // 
            this.textDateArrhes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDateArrhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDateArrhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateArrhes.Location = new System.Drawing.Point(267, 332);
            this.textDateArrhes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDateArrhes.Multiline = true;
            this.textDateArrhes.Name = "textDateArrhes";
            this.textDateArrhes.Size = new System.Drawing.Size(220, 36);
            this.textDateArrhes.TabIndex = 62;
            this.textDateArrhes.TabStop = false;
            this.textDateArrhes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(51, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Hotel";
            // 
            // textDateFin
            // 
            this.textDateFin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDateFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateFin.Location = new System.Drawing.Point(267, 388);
            this.textDateFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDateFin.Multiline = true;
            this.textDateFin.Name = "textDateFin";
            this.textDateFin.Size = new System.Drawing.Size(220, 36);
            this.textDateFin.TabIndex = 66;
            this.textDateFin.TabStop = false;
            this.textDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(51, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Le";
            // 
            // textDateDebut
            // 
            this.textDateDebut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDateDebut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateDebut.Location = new System.Drawing.Point(267, 277);
            this.textDateDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDateDebut.Multiline = true;
            this.textDateDebut.Name = "textDateDebut";
            this.textDateDebut.Size = new System.Drawing.Size(220, 36);
            this.textDateDebut.TabIndex = 64;
            this.textDateDebut.TabStop = false;
            this.textDateDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(51, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Date départ";
            // 
            // TextFacture
            // 
            this.TextFacture.BackColor = System.Drawing.Color.White;
            this.TextFacture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFacture.Location = new System.Drawing.Point(537, 105);
            this.TextFacture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextFacture.Name = "TextFacture";
            this.TextFacture.Size = new System.Drawing.Size(468, 347);
            this.TextFacture.TabIndex = 68;
            this.TextFacture.Text = "";
            // 
            // buttonGen
            // 
            this.buttonGen.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGen.FlatAppearance.BorderSize = 0;
            this.buttonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGen.Location = new System.Drawing.Point(267, 463);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(141, 43);
            this.buttonGen.TabIndex = 69;
            this.buttonGen.Text = "Ajouter";
            this.buttonGen.UseVisualStyleBackColor = false;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.TextFacture);
            this.Controls.Add(this.textDateFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDateDebut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDateArrhes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextDateRes);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Facture";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox TextDateRes;
        private System.Windows.Forms.TextBox textDateArrhes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDateDebut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TextFacture;
        private System.Windows.Forms.Button buttonGen;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}