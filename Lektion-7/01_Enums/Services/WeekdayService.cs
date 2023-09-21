using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class WeekdayService
{
    public void Run()
    {
        var weekday = Weekdays.Tuesday;

        switch (weekday)
        {
            case Weekdays.Monday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Tuesday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Wednesday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Thursday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Friday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Saturday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            case Weekdays.Sunday:
                Console.WriteLine($"It is {weekday} today.");
                break;
            default:
                break;
        }
    }
}
