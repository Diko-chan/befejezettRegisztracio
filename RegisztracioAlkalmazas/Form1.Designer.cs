﻿namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.AgeText = new System.Windows.Forms.Label();
            this.SexText = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FavText = new System.Windows.Forms.Label();
            this.NewHobbiText = new System.Windows.Forms.Label();
            this.NewHobbiBox = new System.Windows.Forms.TextBox();
            this.NewHobbyButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.FavListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AgeBox2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(96, 13);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(136, 20);
            this.NameBox.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(13, 16);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(30, 13);
            this.NameText.TabIndex = 1;
            this.NameText.Text = "Név:";
            // 
            // AgeText
            // 
            this.AgeText.AutoSize = true;
            this.AgeText.Location = new System.Drawing.Point(13, 47);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(62, 13);
            this.AgeText.TabIndex = 2;
            this.AgeText.Text = "Szül. dátum";
            // 
            // SexText
            // 
            this.SexText.AutoSize = true;
            this.SexText.Location = new System.Drawing.Point(13, 87);
            this.SexText.Name = "SexText";
            this.SexText.Size = new System.Drawing.Size(38, 13);
            this.SexText.TabIndex = 4;
            this.SexText.Text = "Neme:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(113, 87);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(39, 17);
            this.FemaleRadioButton.TabIndex = 5;
            this.FemaleRadioButton.Text = "Nő";
            this.FemaleRadioButton.UseMnemonic = false;
            this.FemaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(113, 111);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(45, 17);
            this.MaleRadioButton.TabIndex = 6;
            this.MaleRadioButton.Text = "Férfi";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FavText
            // 
            this.FavText.AutoSize = true;
            this.FavText.Location = new System.Drawing.Point(13, 160);
            this.FavText.Name = "FavText";
            this.FavText.Size = new System.Drawing.Size(81, 13);
            this.FavText.TabIndex = 9;
            this.FavText.Text = "KedvencHobbi:";
            // 
            // NewHobbiText
            // 
            this.NewHobbiText.AutoSize = true;
            this.NewHobbiText.Location = new System.Drawing.Point(12, 300);
            this.NewHobbiText.Name = "NewHobbiText";
            this.NewHobbiText.Size = new System.Drawing.Size(49, 13);
            this.NewHobbiText.TabIndex = 11;
            this.NewHobbiText.Text = "Új hobbi:";
            // 
            // NewHobbiBox
            // 
            this.NewHobbiBox.Location = new System.Drawing.Point(96, 325);
            this.NewHobbiBox.Name = "NewHobbiBox";
            this.NewHobbiBox.Size = new System.Drawing.Size(136, 20);
            this.NewHobbiBox.TabIndex = 12;
            // 
            // NewHobbyButton
            // 
            this.NewHobbyButton.Location = new System.Drawing.Point(157, 351);
            this.NewHobbyButton.Name = "NewHobbyButton";
            this.NewHobbyButton.Size = new System.Drawing.Size(75, 23);
            this.NewHobbyButton.TabIndex = 13;
            this.NewHobbyButton.Text = "Hozzáad";
            this.NewHobbyButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 412);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(157, 412);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 15;
            this.OpenButton.Text = "Betöltés";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // FavListBox
            // 
            this.FavListBox.FormattingEnabled = true;
            this.FavListBox.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.FavListBox.Location = new System.Drawing.Point(96, 184);
            this.FavListBox.Name = "FavListBox";
            this.FavListBox.Size = new System.Drawing.Size(136, 108);
            this.FavListBox.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Szöveges dokumentum|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Szöveges dokumentum|*.txt";
            // 
            // AgeBox2
            // 
            this.AgeBox2.Location = new System.Drawing.Point(96, 39);
            this.AgeBox2.Name = "AgeBox2";
            this.AgeBox2.Size = new System.Drawing.Size(136, 20);
            this.AgeBox2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 447);
            this.Controls.Add(this.AgeBox2);
            this.Controls.Add(this.FavListBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewHobbyButton);
            this.Controls.Add(this.NewHobbiBox);
            this.Controls.Add(this.NewHobbiText);
            this.Controls.Add(this.FavText);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.SexText);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label AgeText;
        private System.Windows.Forms.Label SexText;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label FavText;
        private System.Windows.Forms.Label NewHobbiText;
        private System.Windows.Forms.TextBox NewHobbiBox;
        private System.Windows.Forms.Button NewHobbyButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ListBox FavListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker AgeBox2;
    }
}

