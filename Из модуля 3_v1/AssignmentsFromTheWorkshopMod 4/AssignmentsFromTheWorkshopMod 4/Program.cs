// 4.5.1
(string Name, string SurName, string Login, int LoginLength, bool Pet, double AgeUser, string[] ColorUser) User;
string PetUser;

//4.5.2
Console.Write("Введите свое имя: ");
User.Name = Console.ReadLine();

Console.Write("Введите свою фамилию: ");
User.SurName = Console.ReadLine();

Console.Write("Придумайте свой логин: ");
User.Login = Console.ReadLine();
//4.5.3
User.LoginLength = User.Login.Length;

//4.5.4
Console.Write("Есть у вас животные? Да или Нет: ");
PetUser = Console.ReadLine();

if (PetUser == "Да")
{
    User.Pet = true;
    Console.WriteLine(User.Pet);
    
    if (PetUser == "Нет")
    {
        User.Pet = false;
        Console.WriteLine(User.Pet);
    }  
}
else
{
    Console.WriteLine("Ответьте пожалуйста на вопрос только Да или НЕТ");
}
