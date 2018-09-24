namespace Magasin
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichoerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redémarerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMatérielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btGestionFabricant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 74);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(672, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Accueil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(278, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1080, 491);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gestion des blocs et des casiers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ajouter un nouveau Materiel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Gestion des materiels";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichoerToolStripMenuItem,
            this.travailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichoerToolStripMenuItem
            // 
            this.fichoerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redémarerToolStripMenuItem,
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
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click);
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
            // 
            // btGestionFabricant
            // 
            this.btGestionFabricant.Location = new System.Drawing.Point(32, 281);
            this.btGestionFabricant.Name = "btGestionFabricant";
            this.btGestionFabricant.Size = new System.Drawing.Size(194, 23);
            this.btGestionFabricant.TabIndex = 16;
            this.btGestionFabricant.Text = "Gestion des fabricant";
            this.btGestionFabricant.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btGestionFabricant);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichoerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redémarerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMatérielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMaterielToolStripMenuItem;
        private System.Windows.Forms.Button btGestionFabricant;
    }
}