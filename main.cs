using System;
using System.Xml.Linq;

class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        /*Console.Write("Введите имя: ");
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
        */
        //модификация по мод.4 (использование кортежей)

        (string name, byte age, string brithdate) anketa;

        Console.WriteLine("Введите Ваше имя");

        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите Ваш возраст");

        anketa.age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine("Введите Ваш День рождения");

        anketa.brithdate = (Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);
        Console.WriteLine("Ваш День рождения: {0}", anketa.brithdate);

        //вариант использования кортежа
        var (name, age) = ("Александр", 32);
        Console.WriteLine("Введите имя: {0}", name);
        name = Console.ReadLine();
        Console.WriteLine("Введите возраст: {0}", age);
        age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);
        Console.ReadKey();

        (string Name, string Type, double Age, int NameCount) Pet;
        
        Console.WriteLine("Введите Имя Вашего животного:");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;

        Console.WriteLine("Введите тип Вашего животного:");
        Pet.Type = (Console.ReadLine());

        Console.WriteLine("Введите возраст вашего животного:");
        Pet.Age = double.Parse(Console.ReadLine());
               
        

        Console.WriteLine("Имя Вашего питомца: {0}", Pet.Name);
        Console.WriteLine("Тип Вашего питомца: {0}", Pet.Type);
        Console.WriteLine("Вашему питомцу лет: {0}", Pet.Age);
        Console.WriteLine("Длина имени вашего питомца: {0}", Pet.NameCount);
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
