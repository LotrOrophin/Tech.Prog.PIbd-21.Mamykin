using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static WindowsFormsApp1.MilitaryVehicle;

namespace ProjectLabe
{
    public partial class FormSAU : System.Windows.Forms.Form
    {
        private MilitaryVehicle sau;
        public FormSAU()
        {
            InitializeComponent();
        }

       
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            sau.DrawCar(gr);
            pictureBox.Image = bmp;
        }
        private void buttonCreateMilitaryVehicle(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sau = new MilitaryVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,false);
            sau.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width,
           pictureBox.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUP":
                    sau.MoveTransport(Direction.Up);
                    break;
                case "buttonDOWN":
                    sau.MoveTransport(Direction.Down);
                    break;
                case "buttonLEFT":
                    sau.MoveTransport(Direction.Left);
                    break;
                case "buttonRIGHT":
                    sau.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateSAU(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sau = new SAU(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            sau.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width,
           pictureBox.Height);
            Draw();
        }
    }
}
