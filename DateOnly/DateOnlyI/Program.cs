//aula 256 C# 10
Console.WriteLine("DataHora - Novidades\n");

DateTime datetime = new DateTime();
Console.WriteLine($"DateTime valor padrão {datetime}\n");

DateTime hoje = DateTime.Now;

Console.WriteLine($"A Data de hoje: {hoje} ");

Console.WriteLine($"\nSomente a data: {hoje.ToShortDateString()} (ToShortDateString) ");
Console.WriteLine($"Somente a hora: {hoje.ToShortTimeString()} (ToShortTimeString) ");

Console.ReadKey();