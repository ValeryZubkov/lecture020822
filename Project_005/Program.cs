Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
Console.WriteLine("Ура! Это Маша.");
}
else
{
Console.WriteLine("Привет, " + username);
}
