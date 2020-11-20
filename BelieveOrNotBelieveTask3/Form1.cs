using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieveTask3
{
    public partial class Form1 : Form
    {
        TrueFalse _database;
        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(sfd.FileName);
                _database.Add("Здесь надо создать вопрос", true);
                _database.Save();
                numericQuestion.Minimum = 1;
                numericQuestion.Maximum = 1;
                numericQuestion.Value = 1;
            }

        }

        private void numericQuestion_ValueChanged(object sender, EventArgs e)
        {
            textBoxQuestion.Text = 
                _database[(int)numericQuestion.Value - 1]._text;
            checkBoxIsTrue.Checked = 
                _database[(int)numericQuestion.Value - 1]._trueFalse;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            _database.Add((_database.Count+ 1 ).ToString(), true);
            numericQuestion.Maximum = _database.Count;
            numericQuestion.Value = _database.Count;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (1 == numericQuestion.Maximum || null == _database)
                return;

            _database.Remove((int)numericQuestion.Value);
            numericQuestion.Maximum--;
            //if (numericQuestion.Value > 1)
             //   numericQuestion.Value = numericQuestion.Value;
        }



        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            _database[(int)numericQuestion.Value - 1]._text = textBoxQuestion.Text;
            _database[(int)numericQuestion.Value - 1]._trueFalse = checkBoxIsTrue.Checked;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (null != _database)
                _database.Save();
            else
                MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(ofd.FileName);
                _database.Load();
                numericQuestion.Minimum = 1;
                numericQuestion.Maximum = _database.Count;
                numericQuestion.Value = 1;
            }

        }
    }
}
