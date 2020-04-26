using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreateMessageForm : Form
    {
        private string path;
        public CreateMessageForm()
        {
            InitializeComponent();
        }
        public void Save()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            path = folderBrowserDialog.SelectedPath;
            System.IO.Directory.CreateDirectory(path + "\\" + messageNameTextBox.Text);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
