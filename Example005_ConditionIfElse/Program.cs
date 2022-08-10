Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "ира")
{
    Console.WriteLine("Ура, это же Ира!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
