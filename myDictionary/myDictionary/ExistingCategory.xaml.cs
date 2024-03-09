using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace myDictionary
{

    public partial class ExistingCategory : Window
    {
        private List<string> categories;
        public ExistingCategory()
        {
            InitializeComponent();
            InitializeCategories();
        }
        private void InitializeCategories()
        {
            try
            {
                HashSet<string> uniqueCategories = new HashSet<string>();

                string[] lines = File.ReadAllLines("E:\\AnulII\\MAP\\myDictionary\\myDictionary\\words.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length >= 4)
                    {
                        string category = parts[0];
                        uniqueCategories.Add(category);
                    }
                }
                categories = uniqueCategories.ToList();

                categoryBox.ItemsSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string category = categoryBox.SelectedItem as string; ;
            string description = descriptionBox.Text;
            string photo = pathBox.Text;
            try
            {
                string filePath = "E:\\AnulII\\MAP\\myDictionary\\myDictionary\\words.txt";

                string lineToAdd = category + " " + name + " " + description + " " + photo;

              
                using (StreamWriter writer = new StreamWriter(filePath, true)) //true->scriem la sfaristul fisierului
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
