﻿namespace Magasin
{
    partial class AjoutMateriel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutMateriel2));
            this.listFab = new System.Windows.Forms.ComboBox();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.btInisiliser = new System.Windows.Forms.Button();
            this.btAjout = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFab
            // 
            this.listFab.FormattingEnabled = true;
            this.listFab.Location = new System.Drawing.Point(177, 302);
            this.listFab.Name = "listFab";
            this.listFab.Size = new System.Drawing.Size(276, 21);
            this.listFab.TabIndex = 38;
            // 
            // txtLien
            // 
            this.txtLien.Location = new System.Drawing.Point(177, 258);
            this.txtLien.Name = "txtLien";
            this.txtLien.Size = new System.Drawing.Size(276, 20);
            this.txtLien.TabIndex = 37;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(176, 217);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(277, 20);
            this.txtQuantite.TabIndex = 36;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(177, 172);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(276, 20);
            this.txtPrix.TabIndex = 35;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(176, 103);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(277, 63);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.Text = "";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(177, 65);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(276, 20);
            this.txtRef.TabIndex = 33;
            // 
            // btInisiliser
            // 
            this.btInisiliser.Location = new System.Drawing.Point(234, 374);
            this.btInisiliser.Name = "btInisiliser";
            this.btInisiliser.Size = new System.Drawing.Size(75, 23);
            this.btInisiliser.TabIndex = 31;
            this.btInisiliser.Text = "Initialiser";
            this.btInisiliser.UseVisualStyleBackColor = true;
            this.btInisiliser.Click += new System.EventHandler(this.btInisiliser_Click);
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(123, 374);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 30;
            this.btAjout.Text = "Ajout";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lien";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fabricant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ajout matériel";
            // 
            // AjoutMateriel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 444);
            this.Controls.Add(this.listFab);
            this.Controls.Add(this.txtLien);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.btInisiliser);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutMateriel2";
            this.Text = "Ajout materiel";
            this.Load += new System.EventHandler(this.AjoutMateriel2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listFab;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btInisiliser;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}