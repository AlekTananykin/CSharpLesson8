using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {

        private ForeignWordBase _database;
        private bool _isDatabaseSaved;
        private string _applicationName = "Карманный словарь";

        public Form1()
        {
            InitializeComponent();
        }

        private void miOpenDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _database = new ForeignWordBase() { Filename = ofd.FileName};
                try
                {
                    _database.Load();
                }
                catch (ForeignWordBaseException tfex)
                {
                    ExceptionToMessagebox(tfex);
                    _database = null;
                    return;
                }

                nmWordNumber.Minimum = 1;
                nmWordNumber.Maximum = _database.Count + 1;
                nmWordNumber.Value = nmWordNumber.Maximum;
                SetAddWordMode();

                tbNativeWord.Enabled = true;
                tbForeignWord.Enabled = true;

                this.Text = ofd.FileName;
            }
        }

        private void miNewDb_Click(object sender, EventArgs e)
        {
            _database = new ForeignWordBase();

            nmWordNumber.Minimum = 1;
            nmWordNumber.Maximum = 1;
            nmWordNumber.Value = 1;

            SetAddWordMode();
            tbNativeWord.Enabled = true;
            tbForeignWord.Enabled = true;
        }

        private void miSaveDb_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("База данных не создана", "Сообщение");
                return;
            }
            _isDatabaseSaved = true;

            try
            {
                if (string.IsNullOrEmpty(_database.Filename))
                    miSaveAsDb_Click(sender, e);
                else
                    _database.Save();
            }
            catch (ForeignWordBaseException tfex)
            {
                ExceptionToMessagebox(tfex);
            }
        }

        private void miSaveAsDb_Click(object sender, EventArgs e)
        {
            if (null == _database)
            {
                MessageBox.Show("База данных не создана", "Сообщение");
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
                catch (ForeignWordBaseException tfex)
                {
                    ExceptionToMessagebox(tfex);
                    return;
                }
                this.Text = sfd.FileName;
            }
        }

        private void ExceptionToMessagebox(ForeignWordBaseException tfex)
        {
            StringBuilder message = new StringBuilder();
            message.Append(tfex.Message);

            if (null != tfex.InnerException)
                message.Append(tfex.InnerException.Message);

            MessageBox.Show(message.ToString(), _applicationName, 
                MessageBoxButtons.OK);
        }

        private void miExitDb_Click(object sender, EventArgs e)
        {
            if (null != _database)
            {
                if (!_isDatabaseSaved)
                {
                    if (DialogResult.Yes == MessageBox.Show(
                        "База данных не сохранена. Сохранить?",
                        "Сообщение", MessageBoxButtons.YesNo))
                        miSaveDb_Click(sender, e);
                }
            }

            this.Close();
        }

        private void bnSaveInDb_Click(object sender, EventArgs e)
        {
            _isDatabaseSaved = false;
            _database[(int)nmWordNumber.Value - 1].Foreign = tbForeignWord.Text;
            _database[(int)nmWordNumber.Value - 1].Native = tbNativeWord.Text;
        }

        private void bnDeleteFromDb_Click(object sender, EventArgs e)
        {
            if (null == _database || 0 == _database.Count)
                return;

            _isDatabaseSaved = false;
            _database.Remove((int)nmWordNumber.Value - 1);
            nmWordNumber.Maximum--;

            nmWordNumber_ValueChanged(sender, e);
        }

        private void bnAddToDb_Click(object sender, EventArgs e)
        {
            if (0 == tbNativeWord.Text.Length ||
                0 == tbForeignWord.Text.Length)
                return;

            if (null == _database)
            {
                MessageBox.Show("Создайте новую базу данных",
                    _applicationName);
                return;
            }
            _database.Add(tbNativeWord.Text, tbForeignWord.Text);
            _isDatabaseSaved = false;

            nmWordNumber.Maximum = _database.Count + 1;
            nmWordNumber.Value = _database.Count + 1;

            SetAddWordMode();
        }

        private void nmWordNumber_ValueChanged(object sender, EventArgs e)
        {
            decimal num = nmWordNumber.Value;

            if (num == nmWordNumber.Maximum)
            {
                SetAddWordMode();
                return;
            }

            tbForeignWord.Text = _database[(int)num - 1].Foreign;
            tbNativeWord.Text = _database[(int)num - 1].Native;

            bnDeleteFromDb.Enabled = true;
            bnAddToDb.Enabled = false;
            bnSaveInDb.Enabled = true;
        }

        private void SetAddWordMode()
        {
            tbNativeWord.Text = string.Empty;
            tbForeignWord.Text = String.Empty;

            bnDeleteFromDb.Enabled = false;
            bnAddToDb.Enabled = true;
            bnSaveInDb.Enabled = false;

            nmWordNumber.Enabled = true;
        }
    }
}
