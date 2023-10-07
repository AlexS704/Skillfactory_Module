using System;
using System.Xml.Linq;

class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введите имя: ");
        var name = Console.ReadLine();
        Console.Write("Ваш возраст: ");
        var age = checked((byte) int.Parse(Console.ReadLine()));
        Console.Write("Ваш день рождения: ");
        var brithdate = Console.ReadLine();
        Console.WriteLine("Ваше имя {0}, Ваш возраст {1}, Ваш День рождения {2}", name, age, brithdate);
        Console.Write("Ваш любиымый день недели? Введите порядковый номер: ");
       
        var day = (DaysOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine("Ваш любимый день недели: {0}", day);

        Console.ReadKey();
     

    }
}
enum DaysOfWeek : byte
{
    Tuesday = 1,
    Monday,
    Wednesday,
    Friday
}
