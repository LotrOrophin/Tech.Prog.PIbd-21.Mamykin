namespace ProjectLabe
{
    partial class FormSAU
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLEFT = new System.Windows.Forms.Button();
            this.buttonRIGHT = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 511);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonLEFT
            // 
            this.buttonLEFT.Location = new System.Drawing.Point(601, 476);
            this.buttonLEFT.Name = "buttonLEFT";
            this.buttonLEFT.Size = new System.Drawing.Size(54, 23);
            this.buttonLEFT.TabIndex = 3;
            this.buttonLEFT.Text = "Влево";
            this.buttonLEFT.UseVisualStyleBackColor = true;
            this.buttonLEFT.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.Location = new System.Drawing.Point(725, 476);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(50, 23);
            this.buttonRIGHT.TabIndex = 4;
            this.buttonRIGHT.Text = "Вправо";
            this.buttonRIGHT.UseVisualStyleBackColor = true;
            this.buttonRIGHT.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Location = new System.Drawing.Point(661, 476);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(58, 23);
            this.buttonDOWN.TabIndex = 5;
            this.buttonDOWN.Text = "Вниз";
            this.buttonDOWN.UseVisualStyleBackColor = true;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(661, 447);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(58, 23);
            this.buttonUP.TabIndex = 6;
            this.buttonUP.Text = "Вверх";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "САУ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCreateSAU);
            // 
            // FormSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUP);
            this.Controls.Add(this.buttonDOWN);
            this.Controls.Add(this.buttonRIGHT);
            this.Controls.Add(this.buttonLEFT);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormSAU";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLEFT;
        private System.Windows.Forms.Button buttonRIGHT;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button button2;
    }
}

