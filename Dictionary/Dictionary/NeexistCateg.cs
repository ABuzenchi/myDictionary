﻿using System;
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
    public partial class NeexistCateg : Form
    {
        public NeexistCateg()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = newNameBox.Text;
            string category = newCategoryBox.Text;
            string description = newDescriptionBox.Text;
            string photo = newPhotoBox.Text;
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

