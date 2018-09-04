namespace Magasin
{
    partial class AjoutMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutMateriel));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAjout = new System.Windows.Forms.Button();
            this.btInisiliser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.listFab = new System.Windows.Forms.ComboBox();
            this.listNomCasier = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fabricant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantité";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lien";
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(145, 437);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 11;
            this.btAjout.Text = "Ajout";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // btInisiliser
            // 
            this.btInisiliser.Location = new System.Drawing.Point(255, 437);
            this.btInisiliser.Name = "btInisiliser";
            this.btInisiliser.Size = new System.Drawing.Size(75, 23);
            this.btInisiliser.TabIndex = 12;
            this.btInisiliser.Text = "Initialiser";
            this.btInisiliser.UseVisualStyleBackColor = true;
            this.btInisiliser.Click += new System.EventHandler(this.btInisiliser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nom cassier";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(198, 86);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(276, 20);
            this.txtRef.TabIndex = 16;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(197, 124);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(277, 63);
            this.txtDesc.TabIndex = 17;
            this.txtDesc.Text = "";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(198, 193);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(276, 20);
            this.txtPrix.TabIndex = 18;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(197, 238);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(277, 20);
            this.txtQuantite.TabIndex = 19;
            // 
            // txtLien
            // 
            this.txtLien.Location = new System.Drawing.Point(198, 279);
            this.txtLien.Name = "txtLien";
            this.txtLien.Size = new System.Drawing.Size(276, 20);
            this.txtLien.TabIndex = 20;
            // 
            // listFab
            // 
            this.listFab.FormattingEnabled = true;
            this.listFab.Location = new System.Drawing.Point(198, 323);
            this.listFab.Name = "listFab";
            this.listFab.Size = new System.Drawing.Size(276, 21);
            this.listFab.TabIndex = 21;
            // 
            // listNomCasier
            // 
            this.listNomCasier.FormattingEnabled = true;
            this.listNomCasier.Location = new System.Drawing.Point(198, 376);
            this.listNomCasier.Name = "listNomCasier";
            this.listNomCasier.Size = new System.Drawing.Size(276, 21);
            this.listNomCasier.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-54, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 74);
            this.panel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(247, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ajouter matériel";
            // 
            // AjoutMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listNomCasier);
            this.Controls.Add(this.listFab);
            this.Controls.Add(this.txtLien);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btInisiliser);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjoutMateriel";
            this.Text = "Ajout Materiel";
            this.Load += new System.EventHandler(this.AjoutMateriel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Button btInisiliser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.ComboBox listFab;
        private System.Windows.Forms.ComboBox listNomCasier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}