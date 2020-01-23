using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace WindowsFormsApp1
{
    public class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Garage<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        private Logger logger;      
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            logger = LogManager.GetCurrentClassLogger();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            parkingStages = new List<Garage<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Garage<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Garage<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var car = level[i];
                            if (car != null)
                            {
                                if (car.GetType().Name == "MilitaryVehicle")
                                {
                                    sw.Write(i + ":MilitaryVehicle:");
                                }
                                if (car.GetType().Name == "SAU")
                                {
                                    sw.Write(i + ":SAU:");
                                }
                                sw.WriteLine(car);
                            }
                        }
                        finally { }
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                logger.Error("FileNotFound");
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Garage<ITransport>>(count);
                }
                else
                {
                    logger.Error("Неверный формат файла");
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport car = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Garage<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "MilitaryVehicle")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        car = new MilitaryVehicle(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "SAU")
                    {
                        car = new SAU(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = car;
                }
            }
            return true;
        }
    }
}
    
