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

                //numericQuestion.Minimum = 1;
                //numericQuestion.Maximum = _database.Count + 1;
                //numericQuestion.Value = numericQuestion.Maximum;
                //SetToTheTop();

                //checkBoxIsTrue.Enabled = true;
                //textBoxQuestion.Enabled = true;

                this.Text = ofd.FileName;
            }
        }

        private void miNewDb_Click(object sender, EventArgs e)
        {
            _database = new ForeignWordBase();

            //numericQuestion.Minimum = 1;
            //numericQuestion.Maximum = 1;
            //numericQuestion.Value = 1;

            //SetToTheTop();
            //checkBoxIsTrue.Enabled = true;
            //textBoxQuestion.Enabled = true;

            //textBoxQuestion.Text = "База пуста. Здесь надо создавать вопросы";
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
    }
}
