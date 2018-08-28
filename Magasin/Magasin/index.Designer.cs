namespace Magasin
{
    partial class index
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBloc = new System.Windows.Forms.DataGridView();
            this.dataGridCasier = new System.Windows.Forms.DataGridView();
            this.btAjout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBloc = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterTousLesCasierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index";
            // 
            // dataGridBloc
            // 
            this.dataGridBloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBloc.Location = new System.Drawing.Point(57, 195);
            this.dataGridBloc.Name = "dataGridBloc";
            this.dataGridBloc.RowTemplate.Height = 28;
            this.dataGridBloc.Size = new System.Drawing.Size(225, 353);
            this.dataGridBloc.TabIndex = 1;
            this.dataGridBloc.SelectionChanged += new System.EventHandler(this.dataGridBloc_SelectionChanged);
            // 
            // dataGridCasier
            // 
            this.dataGridCasier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCasier.Location = new System.Drawing.Point(912, 195);
            this.dataGridCasier.Name = "dataGridCasier";
            this.dataGridCasier.Size = new System.Drawing.Size(194, 353);
            this.dataGridCasier.TabIndex = 2;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(939, 565);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 3;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1031, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter une nouvelle casier dans le";
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(951, 149);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(0, 13);
            this.labelBloc.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem1,
            this.ajouterMaterielToolStripMenuItem,
            this.consulterTousLesCasierToolStripMenuItem,
            this.quittezToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(204, 114);
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // ajouterMaterielToolStripMenuItem
            // 
            this.ajouterMaterielToolStripMenuItem.Name = "ajouterMaterielToolStripMenuItem";
            this.ajouterMaterielToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ajouterMaterielToolStripMenuItem.Text = "Ajouter Materiel";
            // 
            // consulterTousLesCasierToolStripMenuItem
            // 
            this.consulterTousLesCasierToolStripMenuItem.Name = "consulterTousLesCasierToolStripMenuItem";
            this.consulterTousLesCasierToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consulterTousLesCasierToolStripMenuItem.Text = "Consulter tous les Casier";
            // 
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 749);
            this.Controls.Add(this.labelBloc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.dataGridCasier);
            this.Controls.Add(this.dataGridBloc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "index";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBloc;
        private System.Windows.Forms.Button btAjout;
        public System.Windows.Forms.DataGridView dataGridCasier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterMaterielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterTousLesCasierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
    }
}