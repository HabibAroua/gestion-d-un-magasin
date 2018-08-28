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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAjouter = new System.Windows.Forms.RadioButton();
            this.rdMinimiser = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 141);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(169, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMinimiser);
            this.groupBox1.Controls.Add(this.rdAjouter);
            this.groupBox1.Location = new System.Drawing.Point(317, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // rdAjouter
            // 
            this.rdAjouter.AutoSize = true;
            this.rdAjouter.Location = new System.Drawing.Point(23, 20);
            this.rdAjouter.Name = "rdAjouter";
            this.rdAjouter.Size = new System.Drawing.Size(58, 17);
            this.rdAjouter.TabIndex = 0;
            this.rdAjouter.TabStop = true;
            this.rdAjouter.Text = "Ajouter";
            this.rdAjouter.UseVisualStyleBackColor = true;
            // 
            // rdMinimiser
            // 
            this.rdMinimiser.AutoSize = true;
            this.rdMinimiser.Location = new System.Drawing.Point(109, 20);
            this.rdMinimiser.Name = "rdMinimiser";
            this.rdMinimiser.Size = new System.Drawing.Size(68, 17);
            this.rdMinimiser.TabIndex = 1;
            this.rdMinimiser.TabStop = true;
            this.rdMinimiser.Text = "Minimiser";
            this.rdMinimiser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifierMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "ModifierMateriel";
            this.Text = "ModifierMateriel";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMinimiser;
        private System.Windows.Forms.RadioButton rdAjouter;
        private System.Windows.Forms.Button button1;
    }
}