Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "иван")
{
    Console.WriteLine("Привет классный Иван!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}