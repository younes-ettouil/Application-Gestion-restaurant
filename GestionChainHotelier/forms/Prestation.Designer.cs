﻿
namespace GestionHotel.forms
{
    partial class Prestation
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
            this.textPrestation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPrestation
            // 
            this.textPrestation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPrestation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textPrestation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrestation.FormattingEnabled = true;
            this.textPrestation.Items.AddRange(new object[] {
            "",
            "Service de chambre ",
            "Transport",
            "Guide troustique",
            "SPA",
            "Petit déjeuné"});
            this.textPrestation.Location = new System.Drawing.Point(407, 140);
            this.textPrestation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrestation.Name = "textPrestation";
            this.textPrestation.Size = new System.Drawing.Size(297, 33);
            this.textPrestation.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(135, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Préstation                           :";
            // 
            // BoxNom
            // 
            this.BoxNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNom.Location = new System.Drawing.Point(408, 68);
            this.BoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxNom.Multiline = true;
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(299, 36);
            this.BoxNom.TabIndex = 39;
            this.BoxNom.TabStop = false;
            this.BoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNom.TextChanged += new System.EventHandler(this.BoxNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(135, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Numéro de réservation   :";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(407, 354);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(299, 98);
            this.textDescription.TabIndex = 48;
            this.textDescription.TabStop = false;
            this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(135, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Description                        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "MAD";
            // 
            // dateDebut
            // 
            this.dateDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.CustomFormat = "dd-MM-yyyy";
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(407, 208);
            this.dateDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(297, 30);
            this.dateDebut.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(135, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Date                                     :";
            // 
            // textPrix
            // 
            this.textPrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrix.Location = new System.Drawing.Point(407, 273);
            this.textPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(299, 36);
            this.textPrix.TabIndex = 50;
            this.textPrix.TabStop = false;
            this.textPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(135, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Prix                                       :";
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.RoyalBlue;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Valider.Location = new System.Drawing.Point(781, 481);
            this.Valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(111, 48);
            this.Valider.TabIndex = 54;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrestation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prestation";
            this.Text = "Préstation";
            this.Load += new System.EventHandler(this.Prestation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox textPrestation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Valider;
    }
}