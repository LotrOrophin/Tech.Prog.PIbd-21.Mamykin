using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class SAU : MilitaryVehicle
    {
        
        public Color DopColor { private set; get; }

        public bool DopKoleso { private set; get; }
        
        public SAU(int maxSpeed, float weight, Color mainColor, Color dopColor, bool dopKoleso, bool phara):
            base (maxSpeed, weight, mainColor, phara)
        {
            DopColor = dopColor;
            DopKoleso = dopKoleso;
        }
        public SAU(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Phara = Convert.ToBoolean(strs[4]);
            }
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
                    if (_startPosY - step - 90 > 0)
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
            g.DrawLine(pen, _startPosX + 90, _startPosY - 6, _startPosX + 95, _startPosY + 2);

            Brush koleso = new SolidBrush(Color.Black);
            g.FillEllipse(koleso, _startPosX + 2, _startPosY - 13, 20, 20);
            if (DopKoleso)
                g.FillEllipse(koleso, _startPosX + 24, _startPosY - 13, 20, 20);
            g.FillEllipse(koleso, _startPosX + 67, _startPosY - 13, 20, 20);

            Brush unit = new SolidBrush(DopColor);
            g.FillRectangle(unit, _startPosX + 5, _startPosY - 25, 40, 19);

            Brush korpus = new SolidBrush(MainColor);
            g.FillRectangle(korpus, _startPosX + 45, _startPosY - 35, 25, 29);
            g.FillRectangle(korpus, _startPosX + 70, _startPosY - 27, 20, 21);
            g.FillRectangle(korpus, _startPosX + 10, _startPosY - 33, 28, 10);

            Brush pushka = new SolidBrush(Color.Black);
            int i = 0;
            while (i < 7) { 
            g.DrawLine(pen, _startPosX + 14+i, _startPosY - 25, _startPosX + 40+i, _startPosY - 60);
                i++;
            }
            i = 0;
            while (i < 7)
            {
                g.DrawLine(pen, _startPosX + 26 + i, _startPosY - 25, _startPosX + 52 + i, _startPosY - 60);
                i++;
            }
            
            g.FillEllipse(koleso, _startPosX, _startPosY - 10, 90, 4);

            g.DrawRectangle(pen, _startPosX + 45, _startPosY - 35, 45, 29);

             if (Phara)
                 g.FillRectangle(unit, _startPosX + 80, _startPosY - 20, 10, 5);

        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + DopKoleso;
        }
    }
}
