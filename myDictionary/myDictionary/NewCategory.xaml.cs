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
    /// <summary>
    /// Interaction logic for NewCategory.xaml
    /// </summary>
    public partial class NewCategory : Window
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string category = categoryBox.Text;
            string description = descriptionBox.Text;
            string photo = imageBox.Text;
            try
            {
                string filePath = "E:\\AnulII\\MAP\\myDictionary\\myDictionary\\words.txt";

                string lineToAdd = category + " " + name + " " + description + " " + photo;

               
                using (StreamWriter writer = new StreamWriter(filePath, true)) 
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

