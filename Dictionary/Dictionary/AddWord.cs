using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class AddWord : Form
    {
        private List<string> categories;



        private void InitializeCategories()
        {
            try
            {
                HashSet<string> uniqueCategories = new HashSet<string>();

                // Citim toate liniile din fișier
                string[] lines = File.ReadAllLines("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt");

                // Iterăm prin fiecare linie și adăugăm categoriile în set-ul de categorii unice
                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length >= 4)
                    {
                        string category = parts[0];
                        uniqueCategories.Add(category);
                    }
                }

                // Adăugăm categoriile unice în ComboBox
                categoriesBox.Items.AddRange(uniqueCategories.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        public AddWord()
        {
            InitializeComponent();
            InitializeCategories();

        }

        private void existButton_Click(object sender, EventArgs e)
        {
            ExistCategory existCategory = new ExistCategory();
            existCategory.ShowDialog();
        }

        private void neexistbutton_Click(object sender, EventArgs e)
        {
            NeexistCateg existCateg = new NeexistCateg();
            existCateg.ShowDialog();
        }
    }
}

