String name = "Куриев Артур Майрбекович";
String group = "ИСП-241";
Console.WriteLine("\nДобро пожаловать в программу!");
Console.WriteLine($"ФИО: {name}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
Console.WriteLine();
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("\n    МЕНЮ    ");
    Console.WriteLine("1 - Показать ФИО");
    Console.WriteLine("2 - Показать группу");
    Console.WriteLine("3 - Показать дату");
    Console.WriteLine("4 - Выход");
    Console.Write("\nВыберите пункт меню: ");
 string num = Console.ReadLine();

switch (num)
{
    case "1":
        Console.WriteLine($"\nФИО: {name}");
        break;
    case "2":
        Console.WriteLine($"\nГруппа: {group}");
        break;
    case "3":
        Console.WriteLine($"\nТекущая дата и время: {DateTime.Now}");
        break;
    case "4":
        Console.WriteLine("\nДо свидания!");
        isRunning = false;
        break;
    default:
        Console.WriteLine("\nНеверный ввод");
        break;
    }
}