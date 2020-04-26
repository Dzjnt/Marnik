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
        public static ListView ListOfMessages = new ListView();

        public MessagesForm()
        {
            InitializeComponent();
       
      
        }
        public void GetImagesFromOpenDialog(string fullPath)
        {
            if(picturesListView.Columns.Count == 0)
            {
                picturesListView.Columns.Add("Obrazki do przeczytania", 150);
                picturesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                picturesListView.View = View.Details;
            }
          
            images.ImageSize = new Size(100, 100);

            try
            {              
                var name = Path.GetFileName(fullPath);
                images.Images.Add(name, Image.FromFile(fullPath));             
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

            PromptBuilder.ClearContent();

            for (int i = 0; i < picturesListView.Items.Count; i++)
            {
                PromptBuilder.AppendText(picturesListView.Items[i].Text);
            }

            // https://superuser.com/questions/590779/how-to-install-more-voices-to-windows-speech
            // zainstalowałem wszystko pokazuje metoda zwraca, ale się nie chce odpalić zagadka dla Ciebie ;p
            // var polishVoice = speechSynthesizer.GetInstalledVoices().First(x => x.VoiceInfo.Id == "TTS_MS_pl-PL_Paulina_11.0");
            //  polishVoice.Enabled = true;
            // speechSynthesizer.SelectVoice("Microsoft Server Speech Text to Speech Voice (pl-PL, Paulina");
            speechSynthesizer.Speak(PromptBuilder);



        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.DefaultExt = "png";
            OpenFileDialog.Filter = "png files (*.png)|*.jpg|All files (*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = OpenFileDialog.FileName;
                GetImagesFromOpenDialog(path);
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
    }
}
