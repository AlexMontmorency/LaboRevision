namespace RevisionExam1
{
    partial class Form1
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
            this.label_Produit = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prix = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.numericUpDown_Prix = new System.Windows.Forms.NumericUpDown();
            this.listBox_Produits = new System.Windows.Forms.ListBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_effacer = new System.Windows.Forms.Button();
            this.label_Nb = new System.Windows.Forms.Label();
            this.numericUpDown_Produits = new System.Windows.Forms.NumericUpDown();
            this.button_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Produit
            // 
            this.label_Produit.AutoSize = true;
            this.label_Produit.Location = new System.Drawing.Point(47, 19);
            this.label_Produit.Name = "label_Produit";
            this.label_Produit.Size = new System.Drawing.Size(49, 16);
            this.label_Produit.TabIndex = 0;
            this.label_Produit.Text = "Produit";
            this.label_Produit.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(47, 74);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(36, 16);
            this.label_Nom.TabIndex = 1;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prix
            // 
            this.label_Prix.AutoSize = true;
            this.label_Prix.Location = new System.Drawing.Point(47, 124);
            this.label_Prix.Name = "label_Prix";
            this.label_Prix.Size = new System.Drawing.Size(29, 16);
            this.label_Prix.TabIndex = 2;
            this.label_Prix.Text = "Prix";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(160, 71);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(324, 22);
            this.textBox_Nom.TabIndex = 3;
            // 
            // numericUpDown_Prix
            // 
            this.numericUpDown_Prix.Location = new System.Drawing.Point(160, 118);
            this.numericUpDown_Prix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Prix.Name = "numericUpDown_Prix";
            this.numericUpDown_Prix.Size = new System.Drawing.Size(324, 22);
            this.numericUpDown_Prix.TabIndex = 4;
            // 
            // listBox_Produits
            // 
            this.listBox_Produits.FormattingEnabled = true;
            this.listBox_Produits.ItemHeight = 16;
            this.listBox_Produits.Location = new System.Drawing.Point(50, 164);
            this.listBox_Produits.Name = "listBox_Produits";
            this.listBox_Produits.Size = new System.Drawing.Size(434, 148);
            this.listBox_Produits.Sorted = true;
            this.listBox_Produits.TabIndex = 5;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(539, 164);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(118, 34);
            this.button_Ajouter.TabIndex = 6;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Enabled = false;
            this.button_Supprimer.Location = new System.Drawing.Point(539, 227);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(118, 33);
            this.button_Supprimer.TabIndex = 7;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_effacer
            // 
            this.button_effacer.Enabled = false;
            this.button_effacer.Location = new System.Drawing.Point(539, 289);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(118, 31);
            this.button_effacer.TabIndex = 8;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = true;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // label_Nb
            // 
            this.label_Nb.AutoSize = true;
            this.label_Nb.Location = new System.Drawing.Point(47, 348);
            this.label_Nb.Name = "label_Nb";
            this.label_Nb.Size = new System.Drawing.Size(126, 16);
            this.label_Nb.TabIndex = 9;
            this.label_Nb.Text = "Nombre de produits";
            this.label_Nb.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDown_Produits
            // 
            this.numericUpDown_Produits.Enabled = false;
            this.numericUpDown_Produits.Location = new System.Drawing.Point(392, 348);
            this.numericUpDown_Produits.Name = "numericUpDown_Produits";
            this.numericUpDown_Produits.Size = new System.Drawing.Size(92, 22);
            this.numericUpDown_Produits.TabIndex = 10;
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(539, 403);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(118, 35);
            this.button_Quitter.TabIndex = 11;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.numericUpDown_Produits);
            this.Controls.Add(this.label_Nb);
            this.Controls.Add(this.button_effacer);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.listBox_Produits);
            this.Controls.Add(this.numericUpDown_Prix);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label_Prix);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.label_Produit);
            this.Name = "Form1";
            this.Text = "Laboratoire de révision";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Produit;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prix;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.NumericUpDown numericUpDown_Prix;
        private System.Windows.Forms.ListBox listBox_Produits;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_effacer;
        private System.Windows.Forms.Label label_Nb;
        private System.Windows.Forms.NumericUpDown numericUpDown_Produits;
        private System.Windows.Forms.Button button_Quitter;
    }
}

