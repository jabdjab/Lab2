using System.Reflection;
using Xunit;
using Calendar;
namespace Calendar.Tests;
public class UnitTest1
{
    [Fact]
    public void LeapYear()
    {
        // Given
        int leap_year = 2024;
        // When
        bool res = Solution12.Check(leap_year);
        // Then
        Assert.True(res);
    }
    [Fact]
    public void NotLeapYear()
    {
        // Given
        int not_leap_year = 2023;
        // When
        bool res = Solution12.Check(not_leap_year);
        // Then
        Assert.False(res);
    }
    [Fact]
    public void Interval()
    {
        // Given
        DateTime date1 = new DateTime(2004, 5, 21);
        DateTime date2 = new DateTime(2024, 3, 10);

        // When
        int res = Solution12.Calc(date1, date2);
        Assert.Equal(7233, res);
        // Then
    }

    [Fact]
    public void WeekDay()
    {
        // Given
        DateTime date = new DateTime(2024, 3, 10);

        // When
        DayOfWeek res = Solution12.Day(date);
        // Then
        Assert.Equal(7, res == DayOfWeek.Sunday ? 7 : (int)res);
    }

}