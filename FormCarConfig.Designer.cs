namespace WindowsFormsApp1
{
    partial class FormCarConfig
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
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.labelSAU = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelDop = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBluuue = new System.Windows.Forms.Panel();
            this.panelPuuurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonToAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            this.groupBoxVehicle.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIn.Location = new System.Drawing.Point(37, 17);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(363, 228);
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.labelSAU);
            this.groupBoxVehicle.Controls.Add(this.label);
            this.groupBoxVehicle.Location = new System.Drawing.Point(43, 31);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(237, 143);
            this.groupBoxVehicle.TabIndex = 1;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Тип ТС";
            // 
            // labelSAU
            // 
            this.labelSAU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSAU.Location = new System.Drawing.Point(75, 83);
            this.labelSAU.Name = "labelSAU";
            this.labelSAU.Size = new System.Drawing.Size(100, 23);
            this.labelSAU.TabIndex = 1;
            this.labelSAU.Text = "САУ";
            this.labelSAU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSportCar_MouseDown);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Location = new System.Drawing.Point(75, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 23);
            this.label.TabIndex = 0;
            this.label.Text = "Бронемашина";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // panelColor
            // 
            this.panelColor.AllowDrop = true;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.labelDop);
            this.panelColor.Controls.Add(this.labelBase);
            this.panelColor.Controls.Add(this.pictureBoxIn);
            this.panelColor.Location = new System.Drawing.Point(493, 31);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(425, 432);
            this.panelColor.TabIndex = 2;
            this.panelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // labelDop
            // 
            this.labelDop.AllowDrop = true;
            this.labelDop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDop.Location = new System.Drawing.Point(90, 352);
            this.labelDop.Name = "labelDop";
            this.labelDop.Size = new System.Drawing.Size(220, 58);
            this.labelDop.TabIndex = 2;
            this.labelDop.Text = "Дополнительный цвет";
            this.labelDop.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDop.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBase
            // 
            this.labelBase.AllowDrop = true;
            this.labelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBase.Location = new System.Drawing.Point(78, 272);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(220, 59);
            this.labelBase.TabIndex = 1;
            this.labelBase.Text = "Основной цвет";
            this.labelBase.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBase.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBluuue);
            this.groupBoxColor.Controls.Add(this.panelPuuurple);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(43, 197);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(88, 166);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(45, 53);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(31, 27);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(45, 100);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(31, 27);
            this.panelGray.TabIndex = 2;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPurple.Location = new System.Drawing.Point(6, 100);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(31, 27);
            this.panelPurple.TabIndex = 2;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(7, 53);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(31, 27);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBluuue
            // 
            this.panelBluuue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBluuue.Location = new System.Drawing.Point(45, 133);
            this.panelBluuue.Name = "panelBluuue";
            this.panelBluuue.Size = new System.Drawing.Size(31, 27);
            this.panelBluuue.TabIndex = 2;
            this.panelBluuue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPuuurple
            // 
            this.panelPuuurple.BackColor = System.Drawing.Color.Purple;
            this.panelPuuurple.Location = new System.Drawing.Point(7, 133);
            this.panelPuuurple.Name = "panelPuuurple";
            this.panelPuuurple.Size = new System.Drawing.Size(31, 27);
            this.panelPuuurple.TabIndex = 2;
            this.panelPuuurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(45, 20);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(31, 27);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(7, 20);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(31, 27);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonToAdd
            // 
            this.buttonToAdd.Location = new System.Drawing.Point(215, 207);
            this.buttonToAdd.Name = "buttonToAdd";
            this.buttonToAdd.Size = new System.Drawing.Size(147, 49);
            this.buttonToAdd.TabIndex = 4;
            this.buttonToAdd.Text = "Добавить";
            this.buttonToAdd.UseVisualStyleBackColor = true;
            this.buttonToAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(215, 276);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(147, 48);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 555);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.groupBoxVehicle);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            this.groupBoxVehicle.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.Label labelSAU;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelBluuue;
        private System.Windows.Forms.Panel panelPuuurple;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDop;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Button buttonToAdd;
        private System.Windows.Forms.Button buttonExit;
    }
}
