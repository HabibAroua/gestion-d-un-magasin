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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMataeriel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche réference";
            // 
            // txtRefCherche
            // 
            this.txtRefCherche.Location = new System.Drawing.Point(183, 66);
            this.txtRefCherche.Name = "txtRefCherche";
            this.txtRefCherche.Size = new System.Drawing.Size(152, 20);
            this.txtRefCherche.TabIndex = 1;
            this.txtRefCherche.TextChanged += new System.EventHandler(this.txtRefCherche_TextChanged);
            // 
            // dataGridMataeriel
            // 
            this.dataGridMataeriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMataeriel.Location = new System.Drawing.Point(26, 112);
            this.dataGridMataeriel.Name = "dataGridMataeriel";
            this.dataGridMataeriel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMataeriel.Size = new System.Drawing.Size(866, 256);
            this.dataGridMataeriel.TabIndex = 2;
            // 
            // RechercheMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 380);
            this.Controls.Add(this.dataGridMataeriel);
            this.Controls.Add(this.txtRefCherche);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RechercheMateriel";
            this.Text = "RechercheMateriel";
            this.Load += new System.EventHandler(this.RechercheMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMataeriel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefCherche;
        private System.Windows.Forms.DataGridView dataGridMataeriel;
    }
}