namespace MarnikProjekt
{
    partial class MessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturesListView = new System.Windows.Forms.ListView();
            this.speakButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.clearListView = new System.Windows.Forms.Button();
            this.messagesListView = new System.Windows.Forms.ListView();
            this.browseMessagesButton = new System.Windows.Forms.Button();
            this.deleteMessagesButton = new System.Windows.Forms.Button();
            this.createMessagesButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // picturesListView
            // 
            this.picturesListView.HideSelection = false;
            this.picturesListView.Location = new System.Drawing.Point(12, 12);
            this.picturesListView.Name = "picturesListView";
            this.picturesListView.Size = new System.Drawing.Size(399, 691);
            this.picturesListView.TabIndex = 0;
            this.picturesListView.UseCompatibleStateImageBehavior = false;
            this.picturesListView.DoubleClick += new System.EventHandler(this.picturesListView_DoubleClick);
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(961, 12);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(140, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Przeczytaj zestaw";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(417, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Załaduj zestaw z dysku";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearListView
            // 
            this.clearListView.Location = new System.Drawing.Point(417, 41);
            this.clearListView.Name = "clearListView";
            this.clearListView.Size = new System.Drawing.Size(140, 23);
            this.clearListView.TabIndex = 6;
            this.clearListView.Text = "Wyczyść listę";
            this.clearListView.UseVisualStyleBackColor = true;
            this.clearListView.Click += new System.EventHandler(this.clearListView_Click);
            // 
            // messagesListView
            // 
            this.messagesListView.HideSelection = false;
            this.messagesListView.Location = new System.Drawing.Point(576, 12);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(379, 691);
            this.messagesListView.TabIndex = 7;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.messagesListView_ItemMouseHover);
            this.messagesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.messagesListView_ItemSelectionChanged);
            this.messagesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messagesListView_MouseClick);
            // 
            // browseMessagesButton
            // 
            this.browseMessagesButton.Location = new System.Drawing.Point(961, 70);
            this.browseMessagesButton.Name = "browseMessagesButton";
            this.browseMessagesButton.Size = new System.Drawing.Size(140, 23);
            this.browseMessagesButton.TabIndex = 10;
            this.browseMessagesButton.Text = "Przeglądaj zestaw ";
            this.browseMessagesButton.UseVisualStyleBackColor = true;
            this.browseMessagesButton.Click += new System.EventHandler(this.browseMessagesButton_Click);
            // 
            // deleteMessagesButton
            // 
            this.deleteMessagesButton.Location = new System.Drawing.Point(961, 41);
            this.deleteMessagesButton.Name = "deleteMessagesButton";
            this.deleteMessagesButton.Size = new System.Drawing.Size(140, 23);
            this.deleteMessagesButton.TabIndex = 11;
            this.deleteMessagesButton.Text = "Usuń element";
            this.deleteMessagesButton.UseVisualStyleBackColor = true;
            this.deleteMessagesButton.Click += new System.EventHandler(this.deleteMessagesButton_Click);
            // 
            // createMessagesButton
            // 
            this.createMessagesButton.Location = new System.Drawing.Point(961, 99);
            this.createMessagesButton.Name = "createMessagesButton";
            this.createMessagesButton.Size = new System.Drawing.Size(140, 23);
            this.createMessagesButton.TabIndex = 12;
            this.createMessagesButton.Text = "Utwórz nowy zestaw";
            this.createMessagesButton.UseVisualStyleBackColor = true;
            this.createMessagesButton.Click += new System.EventHandler(this.createMessagesButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(985, 677);
            this.settingButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(86, 23);
            this.settingButton.TabIndex = 13;
            this.settingButton.Text = "Ustawienia";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.setting_Click);
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 726);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.createMessagesButton);
            this.Controls.Add(this.deleteMessagesButton);
            this.Controls.Add(this.browseMessagesButton);
            this.Controls.Add(this.messagesListView);
            this.Controls.Add(this.clearListView);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.picturesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja do rozpoznawania mowy";
            this.Load += new System.EventHandler(this.MessagesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView picturesListView;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearListView;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.Button browseMessagesButton;
        private System.Windows.Forms.Button deleteMessagesButton;
        private System.Windows.Forms.Button createMessagesButton;
        private System.Windows.Forms.Button settingButton;
    }
}

