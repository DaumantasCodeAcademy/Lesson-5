using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameInputBox.Text))
            {
                MessageBox.Show("Vardas negali buti tuscias");
            }
            else
            {
                OutputTextBox.AppendText($"Sveikas {NameInputBox.Text}");
                OutputTextBox.AppendText("\r\nMalonu tave matyti");
                OutputTextBox.AppendText($"\r\n");
            }
        }
    }
}
