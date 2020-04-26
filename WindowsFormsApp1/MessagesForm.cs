using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MarnikProjekt
{
    public partial class MessagesForm : Form
    {
        public SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public PromptBuilder PromptBuilder = new PromptBuilder();
        public SpeechRecognitionEngine SpeechRecognitionEngine = new SpeechRecognitionEngine();
        public ImageList images = new ImageList();
        private OpenFileDialog OpenFileDialog;
        public bool oneItemWasSelected = false;
        public static string ApplicationPath = string.Empty;
        public decimal WindowMax;
        public decimal ChoiceMax;
        public MessagesForm()
        {
            InitializeComponent();
            ApplicationPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        }
        public void LoadImages()
        {

        }

        public void GetImagesFromOpenDialog(string[] fullPath)
        {
            if(picturesListView.Columns.Count == 0)
            {
                picturesListView.Columns.Add("Obrazki do przeczytania", 150);
                picturesListView.Alignment = ListViewAlignment.Left;
                picturesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.None);
                picturesListView.View = View.Details;
            }
          
            images.ImageSize = new Size(100, 100);

            try
            {
                foreach (string file in fullPath)
                {
                    var name = Path.GetFileName(file);
                    images.Images.Add(name, Image.FromFile(file));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            picturesListView.SmallImageList = images;
            AddImagesToListView(images);

        }
        public void AddImagesToListView(ImageList images)
        {
            //Usunięcie rozszrzeń, żeby nie gadał np. królik.jpg tylko królik
            //images.Images.Keys[j].ToString().Replace(".jpg", "").Replace(".png", "")

            for (int j = 0; j < images.Images.Count; j++)
            {

                this.picturesListView.Items.Add(images.Images.Keys[j].ToString().Replace(".jpg", "").Replace(".png", ""), j);
            }
        }
        private void speakButton_Click(object sender, EventArgs e)
        {
            // https://superuser.com/questions/590779/how-to-install-more-voices-to-windows-speech
            // zainstalowałem wszystko pokazuje metoda zwraca, ale się nie chce odpalić zagadka dla Ciebie ;p
            // var polishVoice = speechSynthesizer.GetInstalledVoices().First(x => x.VoiceInfo.Id == "TTS_MS_pl-PL_Paulina_11.0");
            //  polishVoice.Enabled = true;
            // speechSynthesizer.SelectVoice("Microsoft Server Speech Text to Speech Voice (pl-PL, Paulina");

            PromptBuilder.ClearContent();
            if (oneItemWasSelected)
            {
                PromptBuilder.AppendText(messagesListView.SelectedItems[0].Text);
                speechSynthesizer.Speak(PromptBuilder);
                return;

            }
            else
            {
                for (int i = 0; i < messagesListView.Items.Count; i++)
                {
                    PromptBuilder.AppendText(messagesListView.Items[i].Text);
                }
                speechSynthesizer.Speak(PromptBuilder);
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.DefaultExt = "png";
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.Filter = "png files (*.png)|*.jpg|All files (*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (WindowMax < OpenFileDialog.FileNames.Length)
                {
                    MessageBox.Show($"Zaznaczono zbyt wiele zdjęć! Maksymalna ilość  {WindowMax}");
                    return;
                }
                 else
                {
                    var path = OpenFileDialog.FileNames;
                    GetImagesFromOpenDialog(path);
                }
             
            }
        }

        private void clearListView_Click(object sender, EventArgs e)
        {
            picturesListView.Clear();
            images.Images.Clear();
        }

        private void messagesListView_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    break;
            }
        }

        private void createMessagesButton_Click(object sender, EventArgs e)
        {
           CreateMessageForm createMessageForm = new CreateMessageForm();
           createMessageForm.ShowDialog();
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }



        private void picturesListView_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = picturesListView.SelectedItems[0];
            if(ChoiceMax < messagesListView.Items.Count)
            {
                MessageBox.Show($"Nie można dodać więcej zdjęć! Maksymalna ilość  {WindowMax}");
                return;
            }
            else
            {
                foreach (ListViewItem item in picturesListView.SelectedItems)
                {

                    picturesListView.Items.Remove(item);
                    messagesListView.Items.Add(item);
                }
            }
                        
        }

        private void setting_Click(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Settings button");
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void messagesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (messagesListView.SelectedItems.Count == 0)
            {
                oneItemWasSelected = false;
                return;
            }
            oneItemWasSelected = true;
        }

    }
}
