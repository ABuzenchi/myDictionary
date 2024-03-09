using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class ExistCategory : Form
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
                categBox.Items.AddRange(uniqueCategories.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        public ExistCategory()
        {
            InitializeComponent();
            InitializeCategories();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = newNBox.Text;
            string category = categBox.Text;
            string description = newDBox.Text;
            string photo = newPBox.Text;
            try
            {
                string filePath = "E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt";

                // Textul pe care vrei să îl adaugi

                string lineToAdd = category + " " + name + " " + description + " " + photo;

                // Folosim clasa StreamWriter pentru a adăuga linia nouă
                using (StreamWriter writer = new StreamWriter(filePath, true)) // Parametrul true indică că dorim să adăugăm la sfârșitul fișierului
                {
                    writer.WriteLine(lineToAdd);
                }

                MessageBox.Show("Word added to the dictionary!");
            }
            catch
            {
                MessageBox.Show("Something went wrong! Try again!");

            }

        }
    }
}
