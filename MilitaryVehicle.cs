using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MilitaryVehicle : Vehicle
    {
        
        public const int sauWidth = 100;
        public const int sauHeight = 150;
        public bool Phara { private set; get; }

        public MilitaryVehicle(int maxSpeed, float weight, Color mainColor, bool phara)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Phara = phara;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - sauWidth)
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
                    if (_startPosY - step-90 > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - sauHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, _startPosX, _startPosY - 6, _startPosX - 5, _startPosY + 2);
            g.DrawLine(pen, _startPosX+90, _startPosY - 6, _startPosX + 95, _startPosY + 2);

            Brush koleso = new SolidBrush(Color.Black);
            g.FillEllipse(koleso, _startPosX +2, _startPosY - 13, 20, 20);
            g.FillEllipse(koleso, _startPosX + 67, _startPosY - 13, 20, 20);

            Brush unit = new SolidBrush(MainColor);
            g.FillRectangle(unit, _startPosX+5, _startPosY-25, 40, 19);
            Brush korpus = new SolidBrush(MainColor);
            g.FillRectangle(korpus, _startPosX + 45, _startPosY - 35, 25, 29);
            g.FillRectangle(korpus, _startPosX + 70, _startPosY - 27, 20, 21);
            g.FillRectangle(korpus, _startPosX + 10, _startPosY - 33, 28, 10);

            Brush pushka = new SolidBrush(Color.Black);            
            g.FillEllipse(koleso, _startPosX, _startPosY - 10, 90, 4);

            g.DrawRectangle(pen, _startPosX + 45, _startPosY - 35, 45, 29);
          
            if (Phara)
                g.FillRectangle(unit, _startPosX + 80, _startPosY - 20, 10, 5);
            
        }
    }
}
