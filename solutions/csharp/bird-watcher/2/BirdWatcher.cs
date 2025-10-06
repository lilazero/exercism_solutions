using System;
using System.Linq;
class BirdCount
{
    private readonly int[] birdsPerDay;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };
    public int Today() => birdsPerDay[^1];
    public void IncrementTodaysCount() => birdsPerDay[^1]++;
    public bool HasDayWithoutBirds() => birdsPerDay.Any(i => i == 0);
    public int CountForFirstDays(int numberOfOldestDaysToCount) => birdsPerDay.Take(numberOfOldestDaysToCount).Sum();
    public int BusyDays() => birdsPerDay.Count(i => i >= 5);
    
}
