namespace Magasin
{
    partial class GestionFabricant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFabricant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridFab = new System.Windows.Forms.DataGridView();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.txtNomFab = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFab)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-113, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 74);
            this.panel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(221, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gestion des fabricant";
            // 
            // dataGridFab
            // 
            this.dataGridFab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFab.Location = new System.Drawing.Point(34, 118);
            this.dataGridFab.Name = "dataGridFab";
            this.dataGridFab.Size = new System.Drawing.Size(179, 177);
            this.dataGridFab.TabIndex = 25;
            this.dataGridFab.SelectionChanged += new System.EventHandler(this.dataGridFab_SelectionChanged);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(180, 91);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 26;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(272, 91);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 27;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNomFab
            // 
            this.txtNomFab.Location = new System.Drawing.Point(34, 91);
            this.txtNomFab.Name = "txtNomFab";
            this.txtNomFab.Size = new System.Drawing.Size(118, 20);
            this.txtNomFab.TabIndex = 28;
            // 
            // GestionFabricant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 319);
            this.Controls.Add(this.txtNomFab);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.dataGridFab);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionFabricant";
            this.ShowIcon = false;
            this.Text = "GestionFabricant";
            this.Load += new System.EventHandler(this.GestionFabricant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridFab;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TextBox txtNomFab;
    }
}