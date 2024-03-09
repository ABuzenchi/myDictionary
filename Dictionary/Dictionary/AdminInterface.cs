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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord();
            deleteWord.ShowDialog();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifyWord modifyWord = new ModifyWord();
            modifyWord.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            addWord.ShowDialog();
        }
    }
}
