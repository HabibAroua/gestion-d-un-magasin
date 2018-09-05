namespace Magasin
{
    partial class RechercheMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheMateriel));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRefCherche = new System.Windows.Forms.TextBox();
            this.dataGridMataeriel = new System.Windows.Forms.DataGridView();
            this.btModifier = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btActualiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMataeriel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRefCherche
            // 
            resources.ApplyResources(this.txtRefCherche, "txtRefCherche");
            this.txtRefCherche.Name = "txtRefCherche";
            this.txtRefCherche.TextChanged += new System.EventHandler(this.txtRefCherche_TextChanged);
            // 
            // dataGridMataeriel
            // 
            this.dataGridMataeriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridMataeriel, "dataGridMataeriel");
            this.dataGridMataeriel.Name = "dataGridMataeriel";
            this.dataGridMataeriel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMataeriel.DoubleClick += new System.EventHandler(this.dataGridMataeriel_DoubleClick);
            this.dataGridMataeriel.Enter += new System.EventHandler(this.dataGridMataeriel_Enter);
            // 
            // btModifier
            // 
            resources.ApplyResources(this.btModifier, "btModifier");
            this.btModifier.Name = "btModifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btSupprimer
            // 
            resources.ApplyResources(this.btSupprimer, "btSupprimer");
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btActualiser
            // 
            resources.ApplyResources(this.btActualiser, "btActualiser");
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.UseVisualStyleBackColor = true;
            this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // RechercheMateriel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btActualiser);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.dataGridMataeriel);
            this.Controls.Add(this.txtRefCherche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RechercheMateriel";
            this.Load += new System.EventHandler(this.RechercheMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMataeriel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefCherche;
        public System.Windows.Forms.DataGridView dataGridMataeriel;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}