using System;

namespace TrainApp
{
    class TrainApp : NumericLogic
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Train.Numb = r.Next(1, 20);
            Console.WriteLine("Размер поезда в рандоме: " + r + "\nВычисленный размер поезда: " + Counting(Train.Numb));
            Console.ReadKey();
        }
    }

    class NumericLogic
    {
        /// <summary>
        /// Counting train
        /// </summary>
        /// <param name="r">random arg</param>
        /// <returns></returns>
        static public int Counting(int r)
        {
            return 1;
        }
    }

    class Train
    {
        /// <summary>
        /// global variable Numb
        /// </summary>
        static public int Numb { get; set; }
    }
}