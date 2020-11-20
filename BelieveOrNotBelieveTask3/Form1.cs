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
            DisableQueationElements();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericQuestion_ValueChanged(object sender, EventArgs e)
        {
            decimal num = numericQuestion.Value;
            if (0 == num)
            {
                numericQuestion.Value = 1;
                textBoxQuestion.Text = String.Empty;
                checkBoxIsTrue.Checked = true;
                return;
            }

            if (num > _database.Count)
            {
                textBoxQuestion.Text = String.Empty;
                checkBoxIsTrue.Checked = true;
                return;
            }

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
            _database.Add(textBoxQuestion.Text, checkBoxIsTrue.Checked);
            numericQuestion.Maximum = _database.Count + 1;
            numericQuestion.Value = _database.Count + 1;


            textBoxQuestion.Text = String.Empty;
            checkBoxIsTrue.Checked = true;

            toolStripButtonDelete.Enabled = true;
           
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (null == _database)
                return;

            _database.Remove((int)numericQuestion.Value);
            numericQuestion.Maximum--;

            if (0 == _database.Count)
                toolStripButtonDelete.Enabled = false;

            numericQuestion_ValueChanged(sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            _database[(int)numericQuestion.Value - 1]._text = textBoxQuestion.Text;
            _database[(int)numericQuestion.Value - 1]._trueFalse = checkBoxIsTrue.Checked;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(ofd.FileName);
                try {
                    _database.Load();
                }
                catch (TrueFalseException tfex)
                {
                    ExceptionToMessagebox(tfex);
                    _database = null;
                    return;
                }

                EnableQueationElements();

                numericQuestion.Minimum = 1;
                numericQuestion.Maximum = _database.Count;
                numericQuestion.Value = 1;

                this.Text = ofd.FileName;
            }
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            _database = new TrueFalse(null);

            textBoxQuestion.Text = "База пуста. Здесь надо создать вопрос";
            checkBoxIsTrue.Checked = true;

            EnableQueationElements();

            numericQuestion.Minimum = 1;
            numericQuestion.Maximum = 1;
            numericQuestion.Value = 1;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("База данных не создана", "Сообщение");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(_database.Filename))
                    miSaveAs_Click(sender, e);
                else
                    _database.Save();
            }
            catch (TrueFalseException tfex)
            {
                ExceptionToMessagebox(tfex);
            }
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("База данных не создана", "Сообщение");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _database.Filename = sfd.FileName;
                try
                {
                    _database.Save();
                }
                catch (TrueFalseException tfex)
                {
                    ExceptionToMessagebox(tfex);
                    return;
                }
                this.Text = sfd.FileName;
            }
        }
        private void EnableQueationElements()
        {
            toolStripButtonAdd.Enabled = true;

            if (null != _database && _database.Count > 0)
                toolStripButtonDelete.Enabled = true;
            else
                toolStripButtonDelete.Enabled = false;

            toolStripButtonSave.Enabled = true;
            numericQuestion.Enabled = true;
            checkBoxIsTrue.Enabled = true;
            textBoxQuestion.Enabled = true;
        }
        private void DisableQueationElements()
        {
            toolStripButtonAdd.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonSave.Enabled = false;
            numericQuestion.Enabled = false;
            checkBoxIsTrue.Enabled = false;
            textBoxQuestion.Enabled = false;
            this.Text = "Требуется загрузить или сохранить новую базу данных";
        }

        private void ExceptionToMessagebox(TrueFalseException tfex)
        {
            string message = tfex.Message;
            if (null != tfex.InnerException)
                message += " " + tfex.InnerException.Message;

            MessageBox.Show(message, "Сообщение");
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            aboutForm.Close();
        }
    }
}
