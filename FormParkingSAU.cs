using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormParkingSAU : Form
    {

        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Garage<ITransport> parking;
        public FormParkingSAU()
        {
            InitializeComponent();
            parking = new Garage<ITransport>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var veh = new MilitaryVehicle(100, 1000, dialog.Color, true);
                int place = parking + veh;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetSAU_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var veh = new SAU(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    int place = parking + veh;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5+74, pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    car.DrawCar(gr);
                    pictureBoxTakeVehicle.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    pictureBoxTakeVehicle.Image = bmp;
                }
                Draw();
            }
        }
    }
}
