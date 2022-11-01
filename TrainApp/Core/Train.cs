using System;
using System.Collections.Generic;

namespace Core
{
    class Train
    {
        private int TrainSize { get; set; }
        private System.Data.TrainCollection _trainCollection;

        public Train(int _trainSize)
        {
            TrainSize = _trainSize;
            _trainCollection = new System.Data.TrainCollection();
            _trainCollection.CreateTrain(TrainSize);
        }

        /// <summary>
        /// выводит коллекцию на коноль
        /// </summary>
        public void Display()
        {
            foreach (var s in _trainCollection.GetList())
            {
                if (s != null)
                {
                    Console.WriteLine("Вагон: " + s.Number + " | Освещение: " + s.Lighting);
                }
            }
        }

        /// <summary>
        /// Считает сколько вагонов в поезде
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            List<System.Data.Waggon> list = _trainCollection.GetList();
            list[0].Lighting = true; // включаем свет в первом вагоне
            int count = 0; //счётчик           
            for (int i = 1; i <= 1000; i++)
            {
                count = i; //обновляем счётчик
                if (i == list.Count) //сразу замыкаем поезд под задачку
                {
                    i = 0;
                }

                if (list[i].Lighting == true) //если в вагоне горит свет выключаем его
                {
                    list[i].Lighting = false;
                    i = i - i; //возвращаемся в первый вагон
                }

                if (list[0].Lighting == false)  //проверяем горит ли свет в первом вагоне, если нет - то мы прошли весь поезд, и выводим счётчик
                {
                    return count;
                }
            }
            return count;
        }

    }
}