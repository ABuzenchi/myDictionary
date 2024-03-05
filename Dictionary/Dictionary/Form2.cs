using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form2 : Form
    {
        private Admistrator admin;
        public Form2()
        {
            InitializeComponent();
            admin = new Admistrator();
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (admin.Authenticate(username, password)) 
            {
                AdminInterface form = new AdminInterface();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try again");
            }
              
        }
    }
    }

