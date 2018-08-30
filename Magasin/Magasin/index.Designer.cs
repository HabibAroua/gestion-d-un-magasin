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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBloc = new System.Windows.Forms.DataGridView();
            this.dataGridCasier = new System.Windows.Forms.DataGridView();
            this.btAjout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBloc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichoerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redémarerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMatérielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAjouter = new System.Windows.Forms.Button();
            this.txtBloc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index";
            // 
            // dataGridBloc
            // 
            this.dataGridBloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBloc.Location = new System.Drawing.Point(50, 200);
            this.dataGridBloc.Name = "dataGridBloc";
            this.dataGridBloc.RowTemplate.Height = 28;
            this.dataGridBloc.Size = new System.Drawing.Size(180, 353);
            this.dataGridBloc.TabIndex = 1;
            this.dataGridBloc.SelectionChanged += new System.EventHandler(this.dataGridBloc_SelectionChanged);
            // 
            // dataGridCasier
            // 
            this.dataGridCasier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCasier.Location = new System.Drawing.Point(757, 200);
            this.dataGridCasier.Name = "dataGridCasier";
            this.dataGridCasier.Size = new System.Drawing.Size(194, 353);
            this.dataGridCasier.TabIndex = 2;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(847, 635);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 3;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(977, 218);
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
            this.label2.Location = new System.Drawing.Point(750, 155);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichoerToolStripMenuItem,
            this.travailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichoerToolStripMenuItem
            // 
            this.fichoerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redémarerToolStripMenuItem,
            this.actualiséToolStripMenuItem,
            this.quittezToolStripMenuItem});
            this.fichoerToolStripMenuItem.Name = "fichoerToolStripMenuItem";
            this.fichoerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichoerToolStripMenuItem.Text = "Fichier";
            // 
            // redémarerToolStripMenuItem
            // 
            this.redémarerToolStripMenuItem.Name = "redémarerToolStripMenuItem";
            this.redémarerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.redémarerToolStripMenuItem.Text = "Redémarer";
            this.redémarerToolStripMenuItem.Click += new System.EventHandler(this.redémarerToolStripMenuItem_Click);
            // 
            // actualiséToolStripMenuItem
            // 
            this.actualiséToolStripMenuItem.Name = "actualiséToolStripMenuItem";
            this.actualiséToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.actualiséToolStripMenuItem.Text = "Actualiser";
            this.actualiséToolStripMenuItem.Click += new System.EventHandler(this.actualiséToolStripMenuItem_Click);
            // 
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click_1);
            // 
            // travailToolStripMenuItem
            // 
            this.travailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMatérielsToolStripMenuItem,
            this.ajouterMaterielToolStripMenuItem});
            this.travailToolStripMenuItem.Name = "travailToolStripMenuItem";
            this.travailToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.travailToolStripMenuItem.Text = "Travail";
            // 
            // gestionDesMatérielsToolStripMenuItem
            // 
            this.gestionDesMatérielsToolStripMenuItem.Name = "gestionDesMatérielsToolStripMenuItem";
            this.gestionDesMatérielsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionDesMatérielsToolStripMenuItem.Text = "Gestion des Matériels";
            this.gestionDesMatérielsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMatérielsToolStripMenuItem_Click);
            // 
            // ajouterMaterielToolStripMenuItem
            // 
            this.ajouterMaterielToolStripMenuItem.Name = "ajouterMaterielToolStripMenuItem";
            this.ajouterMaterielToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ajouterMaterielToolStripMenuItem.Text = "Ajouter materiel";
            this.ajouterMaterielToolStripMenuItem.Click += new System.EventHandler(this.ajouterMaterielToolStripMenuItem_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(204, 143);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(94, 23);
            this.btAjouter.TabIndex = 8;
            this.btAjouter.Text = "Ajouter un bloc";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // txtBloc
            // 
            this.txtBloc.Location = new System.Drawing.Point(50, 146);
            this.txtBloc.Name = "txtBloc";
            this.txtBloc.Size = new System.Drawing.Size(148, 20);
            this.txtBloc.TabIndex = 9;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtBloc);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.labelBloc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.dataGridCasier);
            this.Controls.Add(this.dataGridBloc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "index";
            this.Text = "index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichoerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redémarerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMatérielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMaterielToolStripMenuItem;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TextBox txtBloc;
    }
}