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
    public partial class AddWord : Window
    {
        private List<string> categories;
        public AddWord()
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

                categoryList.ItemsSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void existingButton_Click(object sender, RoutedEventArgs e)
        {
            ExistingCategory existingCategory = new ExistingCategory();
            this.Close();
            existingCategory.Show();
        }

        private void newCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            NewCategory newCategory = new NewCategory();
            this.Close();
            newCategory.Show();
        }
    }
}
