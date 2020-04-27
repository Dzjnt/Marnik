namespace WindowsFormsApp1
{
    partial class CreateMessageForm
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
            this.messageNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.messageNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageNameLabel
            // 
            this.messageNameLabel.AutoSize = true;
            this.messageNameLabel.Location = new System.Drawing.Point(5, 15);
            this.messageNameLabel.Name = "messageNameLabel";
            this.messageNameLabel.Size = new System.Drawing.Size(123, 13);
            this.messageNameLabel.TabIndex = 0;
            this.messageNameLabel.Text = "Nazwa nowego zestawu";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(218, 57);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // messageNameTextBox
            // 
            this.messageNameTextBox.Location = new System.Drawing.Point(150, 12);
            this.messageNameTextBox.Name = "messageNameTextBox";
            this.messageNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.messageNameTextBox.TabIndex = 2;
            // 
            // CreateMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 82);
            this.Controls.Add(this.messageNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.messageNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utwórz zestaw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox messageNameTextBox;
    }
}