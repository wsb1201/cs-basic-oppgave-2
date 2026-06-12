Console.Write("Enter name: ");
string? userName = Console.ReadLine();

DateTime now = DateTime.Now;

DayOfWeek[] weekendDays = [DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday];
bool isWeekend = weekendDays.Contains(now.DayOfWeek);

string timeGreeting = now.Hour switch
{
    _ when isWeekend => "God helg",
    >= 5 and < 9 => "God morgen",
    >= 9 and < 12 => "God formiddag",
    >= 12 and < 18 => "God ettermiddag",
    _ => "God kveld",
};

if (string.IsNullOrWhiteSpace(userName))
    Console.WriteLine($"{timeGreeting}!");
else
    Console.WriteLine($"{timeGreeting}, {userName}!");
