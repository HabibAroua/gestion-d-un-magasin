namespace Magasin
{
    partial class ModifierMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierMateriel));
            this.listNomCasier = new System.Windows.Forms.ComboBox();
            this.listFab = new System.Windows.Forms.ComboBox();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btInisiliser = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.txtNomCasier = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNomCasier
            // 
            this.listNomCasier.FormattingEnabled = true;
            this.listNomCasier.Location = new System.Drawing.Point(366, 412);
            this.listNomCasier.Name = "listNomCasier";
            this.listNomCasier.Size = new System.Drawing.Size(117, 21);
            this.listNomCasier.TabIndex = 39;
            this.listNomCasier.SelectedValueChanged += new System.EventHandler(this.listNomCasier_SelectedValueChanged);
            // 
            // listFab
            // 
            this.listFab.FormattingEnabled = true;
            this.listFab.Location = new System.Drawing.Point(366, 356);
            this.listFab.Name = "listFab";
            this.listFab.Size = new System.Drawing.Size(117, 21);
            this.listFab.TabIndex = 38;
            this.listFab.SelectedValueChanged += new System.EventHandler(this.listFab_SelectedValueChanged);
            // 
            // txtLien
            // 
            this.txtLien.Location = new System.Drawing.Point(207, 312);
            this.txtLien.Name = "txtLien";
            this.txtLien.Size = new System.Drawing.Size(276, 20);
            this.txtLien.TabIndex = 37;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(206, 271);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(277, 20);
            this.txtQuantite.TabIndex = 36;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(207, 226);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(276, 20);
            this.txtPrix.TabIndex = 35;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(206, 157);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(277, 63);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.Text = "";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(207, 119);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(276, 20);
            this.txtRef.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nom cassier";
            // 
            // btInisiliser
            // 
            this.btInisiliser.Location = new System.Drawing.Point(265, 462);
            this.btInisiliser.Name = "btInisiliser";
            this.btInisiliser.Size = new System.Drawing.Size(75, 23);
            this.btInisiliser.TabIndex = 31;
            this.btInisiliser.Text = "Annuler";
            this.btInisiliser.UseVisualStyleBackColor = true;
            this.btInisiliser.Click += new System.EventHandler(this.btInisiliser_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(169, 462);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 30;
            this.btModifier.Text = "Enregistrer";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lien";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fabricant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reference";
            // 
            // txtFab
            // 
            this.txtFab.Location = new System.Drawing.Point(206, 356);
            this.txtFab.Name = "txtFab";
            this.txtFab.Size = new System.Drawing.Size(100, 20);
            this.txtFab.TabIndex = 40;
            // 
            // txtNomCasier
            // 
            this.txtNomCasier.Location = new System.Drawing.Point(207, 413);
            this.txtNomCasier.Name = "txtNomCasier";
            this.txtNomCasier.Size = new System.Drawing.Size(100, 20);
            this.txtNomCasier.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-44, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 74);
            this.panel1.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(190, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Modifier Matériel";
            // 
            // ModifierMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNomCasier);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.listNomCasier);
            this.Controls.Add(this.listFab);
            this.Controls.Add(this.txtLien);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btInisiliser);
            this.Controls.Add(this.btModifier);
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
            this.Name = "ModifierMateriel";
            this.Text = "Modifier Materiel";
            this.Load += new System.EventHandler(this.ModifierMateriel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listNomCasier;
        private System.Windows.Forms.ComboBox listFab;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btInisiliser;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.TextBox txtNomCasier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}