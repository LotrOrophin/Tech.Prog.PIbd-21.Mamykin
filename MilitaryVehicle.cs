using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MilitaryVehicle : Vehicle, IComparable<MilitaryVehicle>, IEquatable<MilitaryVehicle>
    {
        
        public const int sauWidth = 100;
        public const int sauHeight = 150;
        public bool Phara { protected set; get; }

        public MilitaryVehicle(int maxSpeed, float weight, Color mainColor, bool phara)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Phara = phara;
        }
        public MilitaryVehicle(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                Phara = Convert.ToBoolean(strs[3]);
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
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(MilitaryVehicle other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(MilitaryVehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is MilitaryVehicle MilitaryVehicleObj))
            {
                return false;
            }
            else
            {
                return Equals(MilitaryVehicleObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
