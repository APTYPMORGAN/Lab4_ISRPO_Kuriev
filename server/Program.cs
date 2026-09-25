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
}