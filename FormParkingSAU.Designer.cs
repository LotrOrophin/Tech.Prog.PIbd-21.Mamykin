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
            this.buttonToPark = new System.Windows.Forms.Button();
            this.buttonToParkVehicle = new System.Windows.Forms.Button();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeVehicle = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(659, 425);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonToPark
            // 
            this.buttonToPark.Location = new System.Drawing.Point(691, 161);
            this.buttonToPark.Name = "buttonToPark";
            this.buttonToPark.Size = new System.Drawing.Size(75, 36);
            this.buttonToPark.TabIndex = 1;
            this.buttonToPark.Text = "Припарковать САУ";
            this.buttonToPark.UseVisualStyleBackColor = true;
            this.buttonToPark.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonToParkVehicle
            // 
            this.buttonToParkVehicle.Location = new System.Drawing.Point(691, 203);
            this.buttonToParkVehicle.Name = "buttonToParkVehicle";
            this.buttonToParkVehicle.Size = new System.Drawing.Size(75, 62);
            this.buttonToParkVehicle.TabIndex = 2;
            this.buttonToParkVehicle.Text = "Припарковать бронемашину";
            this.buttonToParkVehicle.UseVisualStyleBackColor = true;
            this.buttonToParkVehicle.Click += new System.EventHandler(this.buttonSetSAU_Click);
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(691, 404);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeVehicle.TabIndex = 3;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeVehicle_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(678, 268);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(110, 13);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Выкатить установку";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(678, 290);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(726, 287);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox.TabIndex = 6;
            // 
            // pictureBoxTakeVehicle
            // 
            this.pictureBoxTakeVehicle.Location = new System.Drawing.Point(681, 313);
            this.pictureBoxTakeVehicle.Name = "pictureBoxTakeVehicle";
            this.pictureBoxTakeVehicle.Size = new System.Drawing.Size(100, 85);
            this.pictureBoxTakeVehicle.TabIndex = 7;
            this.pictureBoxTakeVehicle.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(681, 13);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // FormParkingSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeVehicle);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonTakeVehicle);
            this.Controls.Add(this.buttonToParkVehicle);
            this.Controls.Add(this.buttonToPark);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParkingSAU";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonToPark;
        private System.Windows.Forms.Button buttonToParkVehicle;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxTakeVehicle;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}
