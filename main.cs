using System;

class MainProgram
{
    public static void Main(string[] args)
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
        Console.WriteLine("Мой размер ноги " + MyShoeSize);
        Console.ReadKey();
    }
}