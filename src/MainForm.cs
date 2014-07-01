using System;
using System.IO;
using System.Windows.Forms;

namespace PdfFieldNameStamper
{
    public partial class MainForm : Form
    {
        private readonly Stamper _stamper;
        public MainForm()
        {
            _stamper = new Stamper(); 
            InitializeComponent();
        }

        public void Process(string input, string output, string password)
        {
            ClearLog();
            Log("Begin processing input file: " + input);

            Log("Stamping field names.");
            try
            {
                _stamper.StampFields(input, output);
                Log("Done. New file created at: " + output);
            }
            catch (Exception ex)
            {
                Log("An error occurred while trying to stamp the fields. The error was: " + ex.Message);
                Log("Done.");
            }

        }

        private void btnBeginProcess_Click(object sender, EventArgs e)
        {
            Process(txtInputPdf.Text, txtOutputPdf.Text, txtOwnerPassword.Text);
        }

        private void ClearLog()
        {
            txtStatus.Text = string.Empty;
        }

        private void Log(string entry)
        {
            txtStatus.AppendText(string.Format("{0}: {1}{2}", DateTime.Now.ToString("G"), entry, Environment.NewLine));
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = true;

            if (!string.IsNullOrEmpty(txtInputPdf.Text))
            {
                fileDialog.InitialDirectory = Path.GetDirectoryName(txtInputPdf.Text);
                fileDialog.FileName = Path.GetFileName(txtInputPdf.Text);
            }

            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtInputPdf.Text = fileDialog.FileName;
                txtOutputPdf.Text = _stamper.GetAutomaticOutputFilePath(txtInputPdf.Text);
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;

            if (!string.IsNullOrEmpty(txtOutputPdf.Text))
            {
                fileDialog.InitialDirectory = Path.GetDirectoryName(txtOutputPdf.Text);
                fileDialog.FileName = Path.GetFileName(txtOutputPdf.Text);
            }

            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputPdf.Text = fileDialog.FileName;
            }
        }
    }
}
