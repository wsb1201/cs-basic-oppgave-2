var timestamp = DateTime.Now;
switch (timestamp.Hour)
{
    case >= 2 and < 5:
        Console.WriteLine("Hva driver du med så sent på natten?");
        break;
    case >= 5 and < 9:
        Console.WriteLine("God morgen!");
        break;
    case >= 9 and < 12:
        Console.WriteLine("God formiddag!");
        break;
    case >= 12 and < 18:
        Console.WriteLine("God ettermiddag!");
        break;
    case >= 18 or < 2:
        Console.WriteLine("God kveld!");
        break;
}
