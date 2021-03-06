﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
     
        public string pathToDefaultMessageSet;
        public MessagesForm()
        {
            InitializeComponent();
            ApplicationPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            WindowMax = Decimal.Parse(MarnikProjekt.Properties.Settings.Default["visibleCommunicationWindowMax"].ToString());
     
            pathToDefaultMessageSet = MarnikProjekt.Properties.Settings.Default["pathToDefaultMessageSet"].ToString();
        }
        public void LoadImages()
        {

        }

        public void GetImagesFromOpenDialog(string[] fullPath, bool loadSession)
        {
            if(picturesListView.Columns.Count == 0)
            {
                picturesListView.Columns.Add("Zestaw komunikatów",350);
                picturesListView.Alignment = ListViewAlignment.Left;
                picturesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.None);
                picturesListView.View = View.Details;
            }
          
            images.ImageSize = new Size(100, 100);
            images.ColorDepth = ColorDepth.Depth32Bit;

            try
            {
                foreach (string file in fullPath)
                {
                    using (var image = Image.FromFile(file))
                    {
                        var name = Path.GetFileName(file);
                        images.Images.Add(name, image.GetThumbnailImage(200,200,null,new IntPtr()));
                    }
                }
                picturesListView.SmallImageList = images;
//                picturesListView.SmallImageList = images;

                AddImagesToListView(images);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //picturesListView.SmallImageList = images;
            //AddImagesToListView(images);

            if(!loadSession) 
                saveSession(fullPath);
            if (images.Images.Count == WindowMax)
                loadButton.Enabled = false;

        }

        private void saveSession(string[] fullPath)
        {
            
            string currentDir = Path.Combine(Directory.GetCurrentDirectory(), "session");

            //if(Directory.Exists(currentDir))
            //    Directory.Delete(currentDir, true);

            if(!Directory.Exists(currentDir))
                Directory.CreateDirectory(currentDir);
            //string[] files = Directory.GetFiles(fullPath);
            foreach(string file in fullPath)
            {
                Console.WriteLine(file);
                try
                {
                    File.Copy(file, Path.Combine(currentDir, Path.GetFileName(file)));
                }catch(IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            MarnikProjekt.Properties.Settings.Default["pathToDefaultMessageSet"] = currentDir;
            MarnikProjekt.Properties.Settings.Default.Save();
        }

        public void AddImagesToListView(ImageList images)
        {
            //Usunięcie rozszrzeń, żeby nie gadał np. królik.jpg tylko królik
            //images.Images.Keys[j].ToString().Replace(".jpg", "").Replace(".png", "")
            this.picturesListView.Items.Clear();
            for (int j = 0; j < images.Images.Count; j++)
            {
                Console.WriteLine($"Add {j}");
                this.picturesListView.Items.Add(images.Images.Keys[j].ToString().Replace(".jpg", "").Replace(".png", ""), j);
            }

        }
        private void Speak(string textToSpeak = null)
        {
            PromptBuilder.ClearContent();

            if(textToSpeak != null)
            {
                PromptBuilder.AppendText(textToSpeak);
                speechSynthesizer.Speak(PromptBuilder);
                return;
            }
            if (oneItemWasSelected)
            {
                for (int i = 0; i < messagesListView.SelectedItems.Count; i++)
                {

                    PromptBuilder.AppendText(messagesListView.SelectedItems[i].Text);
                }
              
                speechSynthesizer.Speak(PromptBuilder);
                return;

            }
            else
            {
                int option = Int32.Parse(MarnikProjekt.Properties.Settings.Default["comminication_selection_option"].ToString());
                if (option == 1)
                {
                    int sleep = Int32.Parse(MarnikProjekt.Properties.Settings.Default["activeTime"].ToString());
                    Console.WriteLine($"sleep: {sleep}");
                    for (int i = 0; i < messagesListView.Items.Count; i++)
                    {
                        speechSynthesizer.Speak(messagesListView.Items[i].Text);
                        System.Threading.Thread.Sleep(sleep);

                    }
                }
                else
                {
                    for (int i = 0; i < messagesListView.Items.Count; i++)
                    {
                        PromptBuilder.AppendText(messagesListView.Items[i].Text);
                    }
                    //speechSynthesizer.Rate = Int32.Parse(MarnikProjekt.Properties.Settings.Default["activeTime"].ToString()) - 10;
                    speechSynthesizer.Speak(PromptBuilder);
                }

            }
        }
        private void speakButton_Click(object sender, EventArgs e)
        {
            // https://superuser.com/questions/590779/how-to-install-more-voices-to-windows-speech
            // zainstalowałem wszystko pokazuje metoda zwraca, ale się nie chce odpalić zagadka dla Ciebie ;p
            // var polishVoice = speechSynthesizer.GetInstalledVoices().First(x => x.VoiceInfo.Id == "TTS_MS_pl-PL_Paulina_11.0");
            //  polishVoice.Enabled = true;
            // speechSynthesizer.SelectVoice("Microsoft Server Speech Text to Speech Voice (pl-PL, Paulina");
            Speak();



        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadImagesFromDialog();
        }

        private void loadImagesFromDialog()
        {
            string pathToDefaultMessageSet = MarnikProjekt.Properties.Settings.Default["pathToDefaultMessageSet"].ToString();
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = pathToDefaultMessageSet != string.Empty ? pathToDefaultMessageSet : @"C:\";
            OpenFileDialog.DefaultExt = "png";
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.Filter = "png files (*.png)|*.jpg|All files (*.*)|*.*";

            WindowMax = Decimal.Parse(Properties.Settings.Default["visibleCommunicationWindowMax"].ToString());

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine($"Current image in list: {images.Images.Count}");
                if (OpenFileDialog.FileNames.Length > WindowMax)
                {
                    MessageBox.Show($"Zaznaczono zbyt wiele zdjęć! Maksymalna ilość  {WindowMax}");
                    return;
                }
                else if (alreadyExists(OpenFileDialog.FileNames))
                {
                    if (MessageBox.Show("W zestawie znajdują się pliki, które mają taką samą nazwę jak już wczytane.\n\n Tak - aby, pominąc duplikaty\n Nie - Wybierz pliki ponownie?", "Zestaw", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GetImagesFromOpenDialog(getFilesThatNameNotInCurrentList(OpenFileDialog.FileNames), false);
                    }
                    else
                        loadImagesFromDialog();
                }
                else
                {
                    var path = OpenFileDialog.FileNames;
                    GetImagesFromOpenDialog(path, false);
                }

            }
            if (images.Images.Count == WindowMax)
                loadButton.Enabled = false;
        }

        private bool alreadyExists(string[] newFiles)
        {
            foreach(ListViewItem item in this.picturesListView.Items)
            {
                foreach(string newFile in newFiles)
                {
                    if (item.Text.Equals(Path.GetFileNameWithoutExtension(newFile)))
                        return true;

                }
            }
            return false;
        }

        private string[] getFilesThatNameNotInCurrentList(string[] files)
        {
            List<string> withoutDuplicates = new List<string>();
            foreach (ListViewItem item in this.picturesListView.Items)
            {
                foreach (string file in files)
                {
                    if (!item.Text.Equals(Path.GetFileNameWithoutExtension(file)))
                        withoutDuplicates.Add(file);

                }
            }
            return withoutDuplicates.ToArray();
        }

        private void clearListView_Click(object sender, EventArgs e)
        {
            string currentDir = Path.Combine(Directory.GetCurrentDirectory(), "session");
            loadButton.Enabled = true;

            foreach (Image img in picturesListView.SmallImageList.Images)
            {
                img.Dispose();
            }

           
            this.picturesListView.Items.Clear();

            picturesListView.Clear();
            foreach(Image img in images.Images)
            {
                img.Dispose();
            }
            images.Images.Clear();
            images = new ImageList();

            for(int i =0; i< picturesListView.Items.Count;i++)
                picturesListView.Items.RemoveAt(i);
            if (Directory.Exists(currentDir))
                Directory.Delete(currentDir, true);
        }

        private void messagesListView_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Click");
            var selectedItem = messagesListView.SelectedItems[0].Text;

            int option = Int32.Parse(MarnikProjekt.Properties.Settings.Default["comminication_selection_option"].ToString());

            if (option == 2)
            {
             if (e.Button == MouseButtons.Left)
                {
                    this.messagesListView.SelectedItems.Clear();
                    Speak(selectedItem);
                }
            }
        }

        private void createMessagesButton_Click(object sender, EventArgs e)
        {
           CreateMessageForm createMessageForm = new CreateMessageForm();
           createMessageForm.ShowDialog();
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            pathToDefaultMessageSet = MarnikProjekt.Properties.Settings.Default["pathToDefaultMessageSet"].ToString();
            Console.WriteLine(pathToDefaultMessageSet);
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            if (!string.IsNullOrEmpty(pathToDefaultMessageSet) && Directory.Exists(pathToDefaultMessageSet))
            {
                FileAttributes fileAttributes = File.GetAttributes(pathToDefaultMessageSet);
                if (fileAttributes.HasFlag(FileAttributes.Directory))
                {
                    if (MessageBox.Show("Czy wczytać ostatni zestaw?", "Zestaw", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Console.WriteLine("Load session");
                        string[] files = Directory.GetFiles(pathToDefaultMessageSet);
                        GetImagesFromOpenDialog(files, true);
                    }
                    else
                    {
                        MessageBox.Show("Załaduj zestaw", "Załaduj zestaw z dysku", MessageBoxButtons.OK);

                        string currentDir = Path.Combine(Directory.GetCurrentDirectory(), "session");

                        if(Directory.Exists(currentDir))
                            Directory.Delete(currentDir, true);
                        loadImagesFromDialog();

                    }
                }

            }
            else
            {
                MessageBox.Show("Załaduj zestaw", "Załaduj zestaw z dysku", MessageBoxButtons.OK);
                loadImagesFromDialog();

            }
            if (images.Images.Count == WindowMax)
                loadButton.Enabled = false;
        }



        private void picturesListView_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = picturesListView.SelectedItems[0];
           decimal ChoiceMax = Decimal.Parse(MarnikProjekt.Properties.Settings.Default["visibleCommunicationChoiceMax"].ToString());
            if (ChoiceMax < messagesListView.Items.Count)
            {
                MessageBox.Show($"Nie można dodać więcej zdjęć! Maksymalna ilość  {ChoiceMax}");
                return;
            }
            else
            {
                foreach (ListViewItem item in picturesListView.SelectedItems)
                {

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Text;
                    messagesListView.Items.Add(listViewItem);
                  
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

        private void messagesListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            int option = Int32.Parse(MarnikProjekt.Properties.Settings.Default["comminication_selection_option"].ToString());
           if (option == 3)
            Speak(e.Item.Text);
        }

        private void deleteMessagesButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in messagesListView.SelectedItems)
            {
                messagesListView.Items.Remove(selectedItem);
            }
        }

        private void browseMessagesButton_Click(object sender, EventArgs e)
        {
            pathToDefaultMessageSet = MarnikProjekt.Properties.Settings.Default["pathToDefaultMessageSet"].ToString();
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = pathToDefaultMessageSet;
            OpenFileDialog.DefaultExt = "png";
            OpenFileDialog.Filter = "png files (*.png)|*.jpg|All files (*.*)|*.*";
            OpenFileDialog.ShowDialog();
        }

        private void messagesListView_ItemActivate(object sender, ListViewItemMouseHoverEventArgs e)
        {
            Console.WriteLine("Item Active");
            Console.WriteLine(e.Item.Text);

            Speak(e.Item.Text);
        }
    }
}
