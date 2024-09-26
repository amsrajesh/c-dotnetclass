internal class Weekdays
{

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    WeekDays weekday;
    internal string sunday;

    public Weekdays()
    {
    }

    public int Weekday { get; set; }
    public string Monday { get; internal set; }
}