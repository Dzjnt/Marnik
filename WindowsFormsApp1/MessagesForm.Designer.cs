namespace MarnikProjekt
{
    partial class MainAppForm
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
            this.SuspendLayout();
            // 
            // picturesListView
            // 
            this.picturesListView.HideSelection = false;
            this.picturesListView.Location = new System.Drawing.Point(12, 12);
            this.picturesListView.Name = "picturesListView";
            this.picturesListView.Size = new System.Drawing.Size(1101, 359);
            this.picturesListView.TabIndex = 0;
            this.picturesListView.UseCompatibleStateImageBehavior = false;
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(158, 377);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(133, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Przeczytaj tekst";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 377);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Załaduj obrazek z dysku";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearListView
            // 
            this.clearListView.Location = new System.Drawing.Point(297, 377);
            this.clearListView.Name = "clearListView";
            this.clearListView.Size = new System.Drawing.Size(133, 23);
            this.clearListView.TabIndex = 6;
            this.clearListView.Text = "Wyczyść listę";
            this.clearListView.UseVisualStyleBackColor = true;
            this.clearListView.Click += new System.EventHandler(this.clearListView_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 414);
            this.Controls.Add(this.clearListView);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.picturesListView);
            this.Name = "MainAppForm";
            this.Text = "Aplikacja do rozpoznawania mowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView picturesListView;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearListView;
    }
}

