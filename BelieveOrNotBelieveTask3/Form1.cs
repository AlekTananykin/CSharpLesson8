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

        bool _isDatabaseSaved;
        string _applicationName;

        public Form1()
        {
            InitializeComponent();
            DisableQueationElements();
            _isDatabaseSaved = false;
            _applicationName = "Верю не верю";
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            CheckDbAndSave(sender, e);
            this.Close();
        }

        private void numericQuestion_ValueChanged(object sender, EventArgs e)
        {
            decimal num = numericQuestion.Value;

            if (num == numericQuestion.Maximum)
            {
                SetToTheTop();
                return;
            }

            textBoxQuestion.Text = _database[(int)num - 1]._text;
            checkBoxIsTrue.Checked = _database[(int)num - 1]._trueFalse;

            toolStripButtonDelete.Enabled = true;
            toolStripButtonAdd.Enabled = false;
            toolStripButtonSave.Enabled = true;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (0 == textBoxQuestion.Text.Length)
                return;

            if (null == _database)
            {
                MessageBox.Show("Создайте новую базу данных", 
                    _applicationName);
                return;
            }
            _database.Add(textBoxQuestion.Text, checkBoxIsTrue.Checked);
            _isDatabaseSaved = false;

            numericQuestion.Maximum = _database.Count + 1;
            numericQuestion.Value = _database.Count + 1;

            SetToTheTop();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (null == _database || 0 == _database.Count)
                return;

            _isDatabaseSaved = false;
            _database.Remove((int)numericQuestion.Value - 1);
            numericQuestion.Maximum--;

            numericQuestion_ValueChanged(sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            _isDatabaseSaved = false;
            _database[(int)numericQuestion.Value - 1]._text = textBoxQuestion.Text;
            _database[(int)numericQuestion.Value - 1]._trueFalse = checkBoxIsTrue.Checked;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            CheckDbAndSave(sender, e);
           
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

                _isDatabaseSaved = true;

                numericQuestion.Minimum = 1;
                numericQuestion.Maximum = _database.Count + 1;
                numericQuestion.Value = numericQuestion.Maximum;
                SetToTheTop();

                checkBoxIsTrue.Enabled = true;
                textBoxQuestion.Enabled = true;

                this.Text = ofd.FileName;
            }
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            CheckDbAndSave(sender, e);
            _isDatabaseSaved = false;
            _database = new TrueFalse(null);

            numericQuestion.Minimum = 1;
            numericQuestion.Maximum = 1;
            numericQuestion.Value = 1;

            SetToTheTop();
            checkBoxIsTrue.Enabled = true;
            textBoxQuestion.Enabled = true;

            textBoxQuestion.Text = "База пуста. Здесь надо создавать вопросы";
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("База данных не создана", 
                    _applicationName);
                return;
            }
            _isDatabaseSaved = true;

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
                MessageBox.Show("База данных не создана", _applicationName);
                return;
            }

            _isDatabaseSaved = true;

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

            MessageBox.Show(message, _applicationName);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            aboutForm.Close();
        }

        private void SetToTheTop()
        {
            textBoxQuestion.Text = String.Empty;
            checkBoxIsTrue.Checked = true;

            toolStripButtonDelete.Enabled = false;
            toolStripButtonAdd.Enabled = true;
            toolStripButtonSave.Enabled = false;

            numericQuestion.Enabled = true;
        }

        private void CheckDbAndSave(object sender, EventArgs e)
        {
            if (null != _database && !_isDatabaseSaved)
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "База данных не сохранена. Сохранить?",
                    _applicationName, MessageBoxButtons.YesNo))
                    miSave_Click(sender, e);
            }
        }
    }
}
