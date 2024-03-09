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
    public partial class DeleteWord : Form
    {
        public DeleteWord()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string word = wordBox.Text;

            if (word != null && word.Length > 0)
            {
                List<string> updatedLines = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(' '); // Folosim spațiul ca separator
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
                    using (StreamWriter sw = new StreamWriter("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt"))
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
