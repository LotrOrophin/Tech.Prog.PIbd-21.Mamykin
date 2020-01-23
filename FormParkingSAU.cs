using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormParkingSAU : Form  
    {

        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        MultiLevelParking parking;
        FormCarConfig form;

        private const int countLevel = 5;
        private Logger logger;


        public FormParkingSAU()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var car = parking[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);
                        if (car != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                           pictureBoxTakeVehicle.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            car.SetPosition(5, 5, pictureBoxTakeVehicle.Width,
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
                        logger.Info("Изъят автомобиль " + car.ToString() + " с места " + maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Error("ParkingNotFound");
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                       pictureBoxTakeVehicle.Height);
                        pictureBoxTakeVehicle.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Неизвестная ошибка");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
        }

        private void AddCar(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + car;
                    logger.Info("Добавлен автомобиль " + car.ToString() + " на место " + place);               
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error("ParkingOverflow");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (parking.SaveData(saveFileDialog.FileName))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (parking.LoadData(openFileDialog.FileName))
                    {
                        MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        logger.Info("Загружено из файла " + openFileDialog.FileName);

                    }
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}

