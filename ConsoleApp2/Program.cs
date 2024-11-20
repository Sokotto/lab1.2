try
{
    Console.WriteLine("Введите объем информации в байтах Z: ");
    double Z = Convert.ToInt64(Console.ReadLine());
    double KB = Z / 1024;
    double MB = KB / 1024;
    double GB = MB / 1024;
    double TB = GB / 1024;
    Console.WriteLine($"Объум информации: ");
    Console.WriteLine($"{Z} байт = {KB:F2} КБ");
    Console.WriteLine($"{Z} байт = {MB:F2} МБ");
    Console.WriteLine($"{Z} байт = {GB:F2} ГБ");
    Console.WriteLine($"{Z} байт = {TB:F2} ТБ");
}
catch
{
    Console.WriteLine("Введите правильно!");
}