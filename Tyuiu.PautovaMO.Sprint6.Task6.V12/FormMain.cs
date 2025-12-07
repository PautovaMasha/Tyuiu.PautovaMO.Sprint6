
using System;
using System.IO;
using Tyuiu.PautovaMO.Sprint6.Task6.V12.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_PMO_Click(object sender, EventArgs e)
        {

            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile_PMO.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_PMO.Text = groupBoxOutPutData_PMO.Text + " - " + openFileDialogTask.FileName;
            buttonDone_PMO.Enabled = true;
        }

        private void buttonHelp_PMO_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_PMO_Click(object sender, EventArgs e)
        {

            textBoxResult_PMO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void openFileDialogTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
