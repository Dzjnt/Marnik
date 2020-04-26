﻿namespace WindowsFormsApp1
{
    partial class SettingsForm
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
            this.first = new System.Windows.Forms.RadioButton();
            this.second = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.RadioButton();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ativeTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WindowMax = new System.Windows.Forms.NumericUpDown();
            this.ChoiceMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ativeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceMax)).BeginInit();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(54, 45);
            this.first.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(514, 17);
            this.first.TabIndex = 1;
            this.first.TabStop = true;
            this.first.Tag = "1";
            this.first.Text = "1. Technika skanowania  i wyboru aktualnie aktywnego komunikatu poprzez kliknięci" +
    "e przycisku myszy ";
            this.first.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(55, 94);
            this.second.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(758, 17);
            this.second.TabIndex = 2;
            this.second.TabStop = true;
            this.second.Tag = "2";
            this.second.Text = "2. Poprzez aktywowanie (przewijanie) kolejnych komunikatów za pomocą lewego przyc" +
    "isku myszy i wyboru aktualnie aktywnego prawym przyciskiem myszy ";
            this.second.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tryb wyboru zestawu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // third
            // 
            this.third.AutoSize = true;
            this.third.Location = new System.Drawing.Point(55, 114);
            this.third.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(166, 17);
            this.third.TabIndex = 4;
            this.third.TabStop = true;
            this.third.Tag = "3";
            this.third.Text = "3. Poprzez wskazanie myszką";
            this.third.UseVisualStyleBackColor = true;
            this.third.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(748, 180);
            this.SaveSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveSettings.Size = new System.Drawing.Size(101, 36);
            this.SaveSettings.TabIndex = 5;
            this.SaveSettings.Text = "Zapisz";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Czas aktywności kolejnych komunikatów z zestawu:";
            // 
            // ativeTime
            // 
            this.ativeTime.Location = new System.Drawing.Point(325, 68);
            this.ativeTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ativeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ativeTime.Name = "ativeTime";
            this.ativeTime.Size = new System.Drawing.Size(43, 20);
            this.ativeTime.TabIndex = 8;
            this.ativeTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Liczba komunikatow widoczna w oknie wyswietlania:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liczba komunikatow widoczna w wybiorze komunikatow:";
            // 
            // WindowMax
            // 
            this.WindowMax.Location = new System.Drawing.Point(334, 155);
            this.WindowMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WindowMax.Name = "WindowMax";
            this.WindowMax.Size = new System.Drawing.Size(51, 20);
            this.WindowMax.TabIndex = 11;
            // 
            // ChoiceMax
            // 
            this.ChoiceMax.Location = new System.Drawing.Point(334, 179);
            this.ChoiceMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChoiceMax.Name = "ChoiceMax";
            this.ChoiceMax.Size = new System.Drawing.Size(51, 20);
            this.ChoiceMax.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 228);
            this.Controls.Add(this.ChoiceMax);
            this.Controls.Add(this.WindowMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ativeTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.third);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ativeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton third;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ativeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown WindowMax;
        private System.Windows.Forms.NumericUpDown ChoiceMax;
    }
}