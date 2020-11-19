using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.BindingContextChanged += new EventHandler(
                numericUpDown1_ValueChanged);
            textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
        }

        void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            decimal textBoxValue;
            if (!decimal.TryParse(
                textBox1.Text, out textBoxValue))
            {
                ShowWrongRangeMessage();
                return;
            }

            if (textBoxValue < numericUpDown1.Minimum ||
                textBoxValue > numericUpDown1.Maximum)
            {
                ShowWrongRangeMessage();
                return;
            }

            numericUpDown1.Value = textBoxValue;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void ShowWrongRangeMessage()
        {
            string message = String.Format(
                "Вводимое значение должно быть числом и " +
                    "лежать в интервале от {0} до {1}", numericUpDown1.Minimum,
                    numericUpDown1.Maximum);
            MessageBox.Show(message);
        }
    }
}
