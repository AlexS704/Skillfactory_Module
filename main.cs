using System;
using System.Xml.Linq;

class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        /*Console.Write("������� ���: ");
        var name = Console.ReadLine();
        Console.Write("��� �������: ");
        var age = checked((byte) int.Parse(Console.ReadLine()));
        Console.Write("��� ���� ��������: ");
        var brithdate = Console.ReadLine();
        Console.WriteLine("���� ��� {0}, ��� ������� {1}, ��� ���� �������� {2}", name, age, brithdate);
        Console.Write("��� �������� ���� ������? ������� ���������� �����: ");
       
        var day = (DaysOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine("��� ������� ���� ������: {0}", day);

        Console.ReadKey();
        */
        //����������� �� ���.4 (������������� ��������)

        (string name, byte age, string brithdate) anketa;

        Console.WriteLine("������� ���� ���");

        anketa.name = Console.ReadLine();

        Console.WriteLine("������� ��� �������");

        anketa.age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine("������� ��� ���� ��������");

        anketa.brithdate = (Console.ReadLine());

        Console.WriteLine("���� ���: {0}", anketa.name);
        Console.WriteLine("��� �������: {0}", anketa.age);
        Console.WriteLine("��� ���� ��������: {0}", anketa.brithdate);

        //������� ������������� �������
        var (name, age) = ("���������", 32);
        Console.WriteLine("������� ���: {0}", name);
        name = Console.ReadLine();
        Console.WriteLine("������� �������: {0}", age);
        age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("���� ���: {0}", name);
        Console.WriteLine("��� �������: {0}", age);
        Console.ReadKey();

        (string Name, string Type, double Age, int NameCount) Pet;
        
        Console.WriteLine("������� ��� ������ ���������:");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;

        Console.WriteLine("������� ��� ������ ���������:");
        Pet.Type = (Console.ReadLine());

        Console.WriteLine("������� ������� ������ ���������:");
        Pet.Age = double.Parse(Console.ReadLine());
               
        

        Console.WriteLine("��� ������ �������: {0}", Pet.Name);
        Console.WriteLine("��� ������ �������: {0}", Pet.Type);
        Console.WriteLine("������ ������� ���: {0}", Pet.Age);
        Console.WriteLine("����� ����� ������ �������: {0}", Pet.NameCount);
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
