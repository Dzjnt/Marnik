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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ativeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(81, 69);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(750, 24);
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
            this.second.Location = new System.Drawing.Point(82, 145);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(1116, 24);
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
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tryb wyboru zestawu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // third
            // 
            this.third.AutoSize = true;
            this.third.Location = new System.Drawing.Point(82, 175);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(244, 24);
            this.third.TabIndex = 4;
            this.third.TabStop = true;
            this.third.Tag = "3";
            this.third.Text = "3. Poprzez wskazanie myszką";
            this.third.UseVisualStyleBackColor = true;
            this.third.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(1122, 277);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveSettings.Size = new System.Drawing.Size(151, 55);
            this.SaveSettings.TabIndex = 5;
            this.SaveSettings.Text = "Zapisz";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Czas aktywności kolejnych komunikatów z zestawu:";
            // 
            // ativeTime
            // 
            this.ativeTime.Location = new System.Drawing.Point(488, 105);
            this.ativeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ativeTime.Name = "ativeTime";
            this.ativeTime.Size = new System.Drawing.Size(65, 26);
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
            this.label3.Location = new System.Drawing.Point(81, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Liczba komunikatow widoczna w oknie wyswietlania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liczba komunikatow widoczna w w wybiorze komunikatow";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(501, 238);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 26);
            this.numericUpDown1.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(501, 275);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 26);
            this.numericUpDown2.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 351);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ativeTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.third);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ativeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}