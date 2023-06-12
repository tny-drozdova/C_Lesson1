string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.Write("Enter a day of the day of the week: ");
string weekday = Console.ReadLine();
int dayNumber = Convert.ToInt32(weekday);

if (dayNumber < 0 || dayNumber > 7)
{
    Console.WriteLine("Such day of a week does not exist!");
}
else
{
    Console.WriteLine(week[dayNumber -1]);
}
