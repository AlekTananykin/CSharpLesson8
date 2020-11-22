using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bnTransform_Click(object sender, EventArgs e)
        {
            if (0 == tbCsvFilePath.Text.Length ||
                0 == tbXmlFilePath.Text.Length)
            {
                MessageBox.Show("Задайте входной и выходной файлы при помощи " +
                    "двойного щелчка. ", _applicationName);
                return;
            }

            try 
            {
                List<Student> students = 
                    StudentsTools.ReadStudentsAsCsv(tbCsvFilePath.Text);

                StudentsTools.SaveStudentsAsXml(students, tbXmlFilePath.Text);

                MessageBox.Show("Преобразование прошло успешно. ", _applicationName);
            }
            catch (StudentsToolsException stex)
            {
                StringBuilder message = new StringBuilder();
                message.Append(stex.Message);
                if (null != stex.InnerException)
                    message.Append(stex.InnerException.Message);

                MessageBox.Show(message.ToString(), _applicationName);
                return;
            }
        }

        private void tbCsvFilePath_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                tbCsvFilePath.Text = ofd.FileName;
        }

        private void tbXmlFilePath_DoubleClick(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Задайте путь сохранение xml файла. ";
            sfd.Filter = "XML files (*.xml)|*.xml";
 
            if (sfd.ShowDialog() == DialogResult.OK)
                tbXmlFilePath.Text = sfd.FileName;

        }
    }
}
