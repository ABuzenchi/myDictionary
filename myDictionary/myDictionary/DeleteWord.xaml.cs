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
    /// Interaction logic for DeleteWord.xaml
    /// </summary>
    public partial class DeleteWord : Window
    {
        public DeleteWord()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string word = inputBox.Text;

            if (word != null && word.Length > 0)
            {
                List<string> updatedLines = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader("E:\\AnulII\\MAP\\myDictionary\\myDictionary\\words.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(' '); 
                            if (parts.Length >= 4)
                            {
                                string cuv = parts[1];

                                if (cuv != word)
                                {
                                    // Păstrăm doar liniile care nu conțin cuvântul de șters
                                    updatedLines.Add(line);
                                }
                            }
                        }
                    }

                    // Suprascriem fișierul cu liniile actualizate
                    using (StreamWriter sw = new StreamWriter("E:\\AnulII\\MAP\\myDictionary\\myDictionary\\words.txt"))
                    {
                        foreach (string updatedLine in updatedLines)
                        {
                            sw.WriteLine(updatedLine);
                        }
                    }

                    MessageBox.Show("Cuvântul a fost șters cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading or writing file: " + ex.Message);
                }
            }
        }
    }
}
