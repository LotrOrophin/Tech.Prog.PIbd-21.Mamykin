using System;

namespace WindowsFormsApp1
{
    partial class FormParkingSAU
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeVehicle = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonTo = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(13, 41);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(839, 397);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(895, 234);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(97, 33);
            this.buttonTakeCar.TabIndex = 2;
            this.buttonTakeCar.Text = "Заказать авто";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(895, 415);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeVehicle.TabIndex = 3;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(882, 270);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(110, 13);
            this.labelVehicle.TabIndex = 4;
            this.labelVehicle.Text = "Выкатить установку";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(882, 290);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(931, 290);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox.TabIndex = 6;
            // 
            // pictureBoxTakeVehicle
            // 
            this.pictureBoxTakeVehicle.Location = new System.Drawing.Point(885, 316);
            this.pictureBoxTakeVehicle.Name = "pictureBoxTakeVehicle";
            this.pictureBoxTakeVehicle.Size = new System.Drawing.Size(100, 85);
            this.pictureBoxTakeVehicle.TabIndex = 7;
            this.pictureBoxTakeVehicle.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(872, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonTo
            // 
            this.buttonTo.Location = new System.Drawing.Point(885, 117);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(49, 59);
            this.buttonTo.TabIndex = 9;
            this.buttonTo.Text = "((((((";
            this.buttonTo.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(940, 117);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(52, 59);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = ")))))";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(895, 193);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(97, 35);
            this.buttonSort.TabIndex = 12;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParkingSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTo);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeVehicle);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelVehicle);
            this.Controls.Add(this.buttonTakeVehicle);
            this.Controls.Add(this.buttonTakeCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParkingSAU";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxTakeVehicle;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonTo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}