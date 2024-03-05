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
    public partial class UserInterface : Form
    {
        private Dictionary<string, Tuple<string, string>> myDictionary = new Dictionary<string, Tuple<string, string>>(); 

        public UserInterface()
        {
            InitializeComponent();
            LoadDictionaryFromFile("E:\\AnulII\\MAP\\Dictionary\\Dictionary\\words.txt");
        }

        private void LoadDictionaryFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' '); // Folosim spațiul ca separator
                        if (parts.Length >= 4)
                        {
                            string word = parts[0];
                            string description = string.Join(" ", parts.Skip(1).Take(parts.Length - 2)); // Reunim restul părților pentru descriere
                            string imagePath = parts[parts.Length - 1]; // Calea către imagine este ultima parte a liniei
                            string categoryName = parts[parts.Length - 1];
                            myDictionary[word] = new Tuple<string, string>(description, imagePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string word = inputBox.Text;

            if (myDictionary.ContainsKey(word))
            {
                Tuple<string, string> data = myDictionary[word];
                outputBox.Text = data.Item1; // Afisăm descrierea

                // Incarcăm imaginea
                string imagePath = data.Item2;
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image not found: " + imagePath);
                }
            }
            else
            {
                outputBox.Text = "Sorry! Word not found";
                string notFoundImagePath = @"E:\AnulII\MAP\Dictionary\Dictionary\photos\NotFound.png";
                if (File.Exists(notFoundImagePath))
                {
                    pictureBox.Image = Image.FromFile(notFoundImagePath);
                }
                else
                {
                    MessageBox.Show("Image not found: " + notFoundImagePath);
                    pictureBox.Image = null;
                }
            }
        }
    }
}
