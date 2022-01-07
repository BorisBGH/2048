using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class WelcomeForm : Form
    {
        public string name = "";
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void start_Button_Click(object sender, EventArgs e)
        {
            if (CheckInput(name_textBox.Text))
            {
                name = name_textBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
        }

        public bool CheckInput(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
               
                return true;

            }
            
            return false;
        }
    }
}
