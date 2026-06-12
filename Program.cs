Console.Write("Enter name: ");
string? userName = Console.ReadLine();

DateTime now = DateTime.Now;

string timeGreeting = now.Hour switch
{
    >= 5 and < 9 => "God morgen",
    >= 9 and < 12 => "God formiddag",
    >= 12 and < 18 => "God ettermiddag",
    _ => "God kveld",
};

if (string.IsNullOrWhiteSpace(userName))
    Console.WriteLine($"{timeGreeting}!");
else
    Console.WriteLine($"{timeGreeting}, {userName}!");
