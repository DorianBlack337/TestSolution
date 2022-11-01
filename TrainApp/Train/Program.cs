using System;

namespace TrainApp
{
    class TrainApp
    {
        public static int Numb { get; set; }

        static void Main(string[] args)
        {
            Random r = new Random();
            Numb = r.Next(1, 10);
            TrainLogic.Train train = new TrainLogic.Train(Numb);
            train.Display();
            Console.WriteLine("Размер поезда выпавший в рандоме: " + Numb + "\nВычисленный размер поезда: " + train.Count());
            Console.ReadKey();
        }
    }
}