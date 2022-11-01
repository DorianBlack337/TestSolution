using System;

namespace TrainApp
{
    class TrainApp
    {
        static void Main(string[] args)
        {
            int rand;
            Random r = new Random();
            rand = r.Next(1, 10);
            Core.Train train = new Core.Train(rand);
            train.Display();
            Console.WriteLine("Размер поезда выпавший в рандоме: " + rand + "\nВычисленный размер поезда: " + train.Count());
            Console.ReadKey();
        }
    }
}