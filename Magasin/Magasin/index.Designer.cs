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
            this.btAjouter = new System.Windows.Forms.Button();
            this.txtBloc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des blocs et des casiers";
            // 
            // dataGridBloc
            // 
            this.dataGridBloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBloc.Location = new System.Drawing.Point(50, 184);
            this.dataGridBloc.Name = "dataGridBloc";
            this.dataGridBloc.RowTemplate.Height = 28;
            this.dataGridBloc.Size = new System.Drawing.Size(180, 175);
            this.dataGridBloc.TabIndex = 1;
            this.dataGridBloc.SelectionChanged += new System.EventHandler(this.dataGridBloc_SelectionChanged);
            // 
            // dataGridCasier
            // 
            this.dataGridCasier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCasier.Location = new System.Drawing.Point(372, 171);
            this.dataGridCasier.Name = "dataGridCasier";
            this.dataGridCasier.Size = new System.Drawing.Size(194, 176);
            this.dataGridCasier.TabIndex = 2;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(372, 365);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(194, 23);
            this.btAjout.TabIndex = 3;
            this.btAjout.Text = "Ajouter un matériel dans ce casier";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 144);
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
            this.label2.Location = new System.Drawing.Point(369, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter une nouvelle casier dans le";
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(538, 153);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(36, 13);
            this.labelBloc.TabIndex = 6;
            this.labelBloc.Text = "Bloc x";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-47, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 77);
            this.panel1.TabIndex = 10;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(661, 144);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 11;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Supprimer le bloc séléctionné";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(777, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBloc);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.labelBloc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.dataGridCasier);
            this.Controls.Add(this.dataGridBloc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "index";
            this.Text = "index";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TextBox txtBloc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button button2;
    }
}