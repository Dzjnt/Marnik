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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            WindowMax.Value = Decimal.Parse(Properties.Settings.Default["visibleCommunicationWindowMax"].ToString());
            ChoiceMax.Value = Decimal.Parse(Properties.Settings.Default["visibleCommunicationChoiceMax"].ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            var checkedCommunicationOption = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            int selected = Int32.Parse(checkedCommunicationOption.Tag.ToString());
            Console.WriteLine(selected);

            if (selected == 1)
                Properties.Settings.Default["ativeTime"] = ativeTime.Value;
            Properties.Settings.Default["comminication_selection_option"] = selected;

            Properties.Settings.Default["visibleCommunicationWindowMax"] = WindowMax.Value;
            Properties.Settings.Default["visibleCommunicationChoiceMax"] = ChoiceMax.Value;

            Properties.Settings.Default.Save();
        }
    }
}
