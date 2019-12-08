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
            this.labelText = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeVehicle = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonTo = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
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
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(691, 180);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(97, 85);
            this.buttonTakeCar.TabIndex = 2;
            this.buttonTakeCar.Text = "Заказать авто";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(691, 404);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeVehicle.TabIndex = 3;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeCar_Click);
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
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonTo
            // 
            this.buttonTo.Location = new System.Drawing.Point(681, 115);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(49, 59);
            this.buttonTo.TabIndex = 9;
            this.buttonTo.Text = "((((((";
            this.buttonTo.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(736, 115);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(52, 59);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = ")))))";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // FormParkingSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTo);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeVehicle);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonTakeVehicle);
            this.Controls.Add(this.buttonTakeCar);
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
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxTakeVehicle;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonTo;
        private System.Windows.Forms.Button buttonBack;
    }
}