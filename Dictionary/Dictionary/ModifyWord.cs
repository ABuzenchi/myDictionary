using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class ModifyWord : Form
    {
        public ModifyWord()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string word = inBox.Text;
            bool gasit = false;

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
                                else
                                {
                                    gasit = true;
                                    nameBox.Text = cuv;
                                    catBox.Text = parts[0];
                                    descriptionBox.Text = string.Join(" ", parts.Skip(2).Take(parts.Length - 3));
                                    imagineBox.Text = parts[parts.Length - 1];
                                }
                            }
                        }
                        if (gasit == false)
                        {
                            nameBox.Text = "notFound";
                            catBox.Text = "notFound";
                            descriptionBox.Text = "notFound";
                            imagineBox.Text = "notFound";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading or writing file: " + ex.Message);
                }

            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string initialName = inBox.Text;
            string name = nameBox.Text;
            string description = descriptionBox.Text;
            string img = imagineBox.Text;
            string categ = catBox.Text;
            if (name == "notFound" || description == "notFound" || img == "notFound" || categ == "notFound")
            {
                MessageBox.Show("U can't do this!!!!!");
                return;
            }
            else
            {
                //cautare in fisier dupa numeInitial, modificare continut cu datele noi
                try
                {
                    // Citim toate liniile din fișier
                    string[] lines = File.ReadAllLines("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt");

                    // Iterăm prin fiecare linie și verificăm dacă conține cuvântul de modificat
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(' ');

                        if (parts.Length >= 4 && parts[1] == initialName)
                        {
                            // Am găsit linia cu cuvântul de modificat, actualizăm informațiile
                            lines[i] = $"{categ} {name} {description} {img}";
                            break; // Nu mai este nevoie să căutăm în continuare
                        }
                    }

                    // Suprascriem fișierul cu liniile actualizate
                    File.WriteAllLines("E:\\AnulII\\MAP\\myDictionary.git\\Dictionary\\Dictionary\\words.txt", lines);

                    MessageBox.Show("Cuvântul a fost modificat cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading or writing file: " + ex.Message);
                }


            }
        }
    }
}

