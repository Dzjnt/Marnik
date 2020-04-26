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
            this.loadMessagesButton = new System.Windows.Forms.Button();
            this.browseMessagesButton = new System.Windows.Forms.Button();
            this.deleteMessagesButton = new System.Windows.Forms.Button();
            this.createMessagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // picturesListView
            // 
            this.picturesListView.HideSelection = false;
            this.picturesListView.Location = new System.Drawing.Point(12, 12);
            this.picturesListView.Name = "picturesListView";
            this.picturesListView.Size = new System.Drawing.Size(1179, 209);
            this.picturesListView.TabIndex = 0;
            this.picturesListView.UseCompatibleStateImageBehavior = false;
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(919, 227);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(133, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Przeczytaj tekst";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(773, 227);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Załaduj obrazek z dysku";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearListView
            // 
            this.clearListView.Location = new System.Drawing.Point(1058, 227);
            this.clearListView.Name = "clearListView";
            this.clearListView.Size = new System.Drawing.Size(133, 23);
            this.clearListView.TabIndex = 6;
            this.clearListView.Text = "Wyczyść listę";
            this.clearListView.UseVisualStyleBackColor = true;
            this.clearListView.Click += new System.EventHandler(this.clearListView_Click);
            // 
            // messagesListView
            // 
            this.messagesListView.HideSelection = false;
            this.messagesListView.Location = new System.Drawing.Point(14, 304);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(1179, 221);
            this.messagesListView.TabIndex = 7;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messagesListView_MouseClick);
            // 
            // loadMessagesButton
            // 
            this.loadMessagesButton.Location = new System.Drawing.Point(1031, 531);
            this.loadMessagesButton.Name = "loadMessagesButton";
            this.loadMessagesButton.Size = new System.Drawing.Size(160, 23);
            this.loadMessagesButton.TabIndex = 8;
            this.loadMessagesButton.Text = "Załaduj zestaw komunikatów";
            this.loadMessagesButton.UseVisualStyleBackColor = true;
            // 
            // browseMessagesButton
            // 
            this.browseMessagesButton.Location = new System.Drawing.Point(693, 531);
            this.browseMessagesButton.Name = "browseMessagesButton";
            this.browseMessagesButton.Size = new System.Drawing.Size(119, 23);
            this.browseMessagesButton.TabIndex = 10;
            this.browseMessagesButton.Text = "Przeglądaj zestaw ";
            this.browseMessagesButton.UseVisualStyleBackColor = true;
            // 
            // deleteMessagesButton
            // 
            this.deleteMessagesButton.Location = new System.Drawing.Point(818, 531);
            this.deleteMessagesButton.Name = "deleteMessagesButton";
            this.deleteMessagesButton.Size = new System.Drawing.Size(86, 23);
            this.deleteMessagesButton.TabIndex = 11;
            this.deleteMessagesButton.Text = "Usuń zestaw";
            this.deleteMessagesButton.UseVisualStyleBackColor = true;
            // 
            // createMessagesButton
            // 
            this.createMessagesButton.Location = new System.Drawing.Point(910, 531);
            this.createMessagesButton.Name = "createMessagesButton";
            this.createMessagesButton.Size = new System.Drawing.Size(115, 23);
            this.createMessagesButton.TabIndex = 12;
            this.createMessagesButton.Text = "Utwórz nowy zestaw";
            this.createMessagesButton.UseVisualStyleBackColor = true;
            this.createMessagesButton.Click += new System.EventHandler(this.createMessagesButton_Click);
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 574);
            this.Controls.Add(this.createMessagesButton);
            this.Controls.Add(this.deleteMessagesButton);
            this.Controls.Add(this.browseMessagesButton);
            this.Controls.Add(this.loadMessagesButton);
            this.Controls.Add(this.messagesListView);
            this.Controls.Add(this.clearListView);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.picturesListView);
            this.Name = "MessagesForm";
            this.Text = "Aplikacja do rozpoznawania mowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView picturesListView;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearListView;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.Button loadMessagesButton;
        private System.Windows.Forms.Button browseMessagesButton;
        private System.Windows.Forms.Button deleteMessagesButton;
        private System.Windows.Forms.Button createMessagesButton;
    }
}

