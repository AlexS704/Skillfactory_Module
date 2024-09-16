using System;

namespace Из_модуля_3_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Александр";
            byte MyAge = 32;
            bool MyPet = true;
            float MyShoeSize = 44.4f;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Как Вас зовут?");
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine(MyName + ", сколько Вам лет?");
            Console.WriteLine("Мне " + MyAge);
            Console.WriteLine(MyName + ", У вас есть домашнее животное?");
            Console.WriteLine(MyPet);
            Console.WriteLine(MyName + ", какой у Вас размер ноги?");
            Console.WriteLine("Мой размер ноги " + MyShoeSize + "\n");
            //Console.ReadKey();

            //вывод длины типа данных
            Console.WriteLine("Intmin {0}", int.MinValue);
            Console.WriteLine("IntMax {0}", int.MaxValue + "\n");
            //Console.ReadKey();

            //работа со списками
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Monday;
            Console.WriteLine(MyFavoriteDay);


            Semaphore MySemaphore;
            MySemaphore = Semaphore.Green;
            Console.WriteLine(MySemaphore);
            Console.WriteLine("\tПривет,\n мир!");

            string name = "Jane";
            byte age = 32;
            string favcolor = "black";

            Console.WriteLine("{0}\n{1}\n{2}", name, age, favcolor);


            Console.ReadKey();
        }
    }
    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }

    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}