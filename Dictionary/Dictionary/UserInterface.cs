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
        private Dictionary<string, Tuple<string, string,string>> myDictionary = new Dictionary<string, Tuple<string, string,string>>(); 

        public UserInterface()
        {
            InitializeComponent();
            LoadDictionaryFromFile("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt");
            InitializeCategories();
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
                            string category = parts[0];
                            string word = parts[1];
                            string description = string.Join(" ", parts.Skip(2).Take(parts.Length - 3)); // Reunim restul părților pentru descriere
                            string imagePath = parts[parts.Length - 1]; // Calea către imagine este ultima parte a liniei
                           
                            myDictionary[word] = new Tuple<string, string,string>(category,description, imagePath);
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
                Tuple<string, string,string> data = myDictionary[word];
                outputBox.Text = data.Item2; // Afisăm descrierea
                categoryBox.Text = data.Item1;

                // Incarcăm imaginea
                string imagePath = data.Item3;
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
                categoryBox.Text = "None";
                string notFoundImagePath = @"E:\AnulII\MAP\myDictionary.git\Dictionary\Dictionary\photos\NotFound.png";
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
        private void InitializeCategories()
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

        private void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categ=categBox.Text;
            if(categ!=null) 
            {
                List<string> cuvinte=new List<string>();
                foreach( var word in myDictionary)
                {
                    if(word.Key==categ)
                    {
                        cuvinte.Add(word.Value.Item1);
                    }
                }
                inputBox.AutoCompleteCustomSource.Clear();
                inputBox.AutoCompleteCustomSource.AddRange(cuvinte.ToArray());
            }
        }
       
        
    }
}
