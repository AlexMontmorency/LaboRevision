using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionExam1
{
    public partial class Form1 : Form
    {
        Produit[] tabProduit = new Produit[Produit.NbProduits];
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAjouter_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox_Nom.Text)) {
                listBox_Produits.Items.Add(textBox_Nom.Text);
                Produit.NbProduits++;
                numericUpDown_Produits.Value= Produit.NbProduits;
                buttonDisabler();
                Produit unProduit = new Produit(textBox_Nom.Text, numericUpDown_Prix.Value);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            listBox_Produits.Items.Remove(listBox_Produits.SelectedItem);
            Produit.NbProduits--;
            numericUpDown_Produits.Value = Produit.NbProduits;
            buttonDisabler();
            

        }

        private void button_effacer_Click(object sender, EventArgs e)
        {
            listBox_Produits.Items.Clear();
            Produit.NbProduits = 0;
            numericUpDown_Produits.Value = Produit.NbProduits;
            buttonDisabler();
            

        }


        private void buttonDisabler()
        {
            button_Supprimer.Enabled = listBox_Produits.Items.Count > 0;
            button_effacer.Enabled = listBox_Produits.Items.Count > 0;
        }


    }
}
