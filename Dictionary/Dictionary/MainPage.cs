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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Form2 form=new Form2();
            form.ShowDialog();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserInterface userInterface = new UserInterface();  
            userInterface.ShowDialog();
        }
    }
}
