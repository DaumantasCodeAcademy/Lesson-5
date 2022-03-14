using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_globalus_kintamieji
{
    public partial class Form1 : Form
    {
        private DataStorage storage;

        public Form1()
        {
            storage = new DataStorage();
            InitializeComponent();
        }

        private void PutToArrayButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HeightInputBox.Text))
            {
                MessageBox.Show("Ugis negali buti neuzpildytas");
                return;
            }

            if (string.IsNullOrWhiteSpace(WeightInputBox.Text))
            {
                MessageBox.Show("Svoris negali buti neuzpildytas");
                return;
            }

            decimal height = Convert.ToDecimal(HeightInputBox.Text);
            decimal weight = Convert.ToDecimal(WeightInputBox.Text);
            storage.Add(height, weight);

            HeightInputBox.Clear();
            WeightInputBox.Clear();
            MessageBox.Show("Reiksmes sekmingai pridetos i masyva");
        }

        private void ShowArrayButton_Click(object sender, EventArgs e)
        {
            int elementsCount = storage.currentElementsCount;
            decimal[,] data = storage.GetStorageData();
            for (int i = 0; i < elementsCount; i++)
            {
                ArrayDisplayTextBox.AppendText($"Ugis: {data[i, 0]}. Svoris: {data[i, 1]}\r\n");
            }
        }
    }
}
