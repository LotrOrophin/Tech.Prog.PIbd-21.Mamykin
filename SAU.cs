﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class SAU
    {
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public bool DopKoleso { private set; get; }
        public bool Phara
        {
            private set; get;
        }





       public SAU(int maxSpeed, float weight, Color mainColor, Color dopColor, bool dopKoleso, bool phara)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DopKoleso = dopKoleso;
            Phara = phara;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, _startPosX, _startPosY - 6, _startPosX - 5, _startPosY + 2);
            g.DrawLine(pen, _startPosX + 90, _startPosY - 6, _startPosX + 95, _startPosY + 2);

            Brush koleso = new SolidBrush(Color.Black);
            g.FillEllipse(koleso, _startPosX + 2, _startPosY - 13, 20, 20);
            if (DopKoleso)
                g.FillEllipse(koleso, _startPosX + 24, _startPosY - 13, 20, 20);
            g.FillEllipse(koleso, _startPosX + 67, _startPosY - 13, 20, 20);




            Brush unit = new SolidBrush(DopColor);
            g.FillRectangle(unit, _startPosX + 5, _startPosY - 25, 40, 19);
           // g.FillEllipse(unit, _startPosX + 12, _startPosY - 100, 22, 20);

            Brush korpus = new SolidBrush(MainColor);
            g.FillRectangle(korpus, _startPosX + 45, _startPosY - 35, 25, 29);
            g.FillRectangle(korpus, _startPosX + 70, _startPosY - 27, 20, 21);
            g.FillRectangle(korpus, _startPosX + 10, _startPosY - 33, 28, 10);

            Brush pushka = new SolidBrush(Color.Black);
            //g.FillRectangle(pushka, _startPosX + 14, _startPosY - 90, 20, 65);
            int i = 0;
            while (i < 7) { 
            g.DrawLine(pen, _startPosX + 14+i, _startPosY - 25, _startPosX + 40+i, _startPosY - 90);
                i++;
            }
            i = 0;
            while (i < 7)
            {
                g.DrawLine(pen, _startPosX + 26 + i, _startPosY - 25, _startPosX + 52 + i, _startPosY - 90);
                i++;
            }
            
            g.FillEllipse(koleso, _startPosX, _startPosY - 10, 90, 4);

            g.DrawRectangle(pen, _startPosX + 45, _startPosY - 35, 45, 29);

             if (Phara)
                 g.FillRectangle(unit, _startPosX + 80, _startPosY - 20, 10, 5);

        }
    }
}
