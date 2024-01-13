namespace DayOfTheProgramme;

public class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string DayOfProgrammer(int year)
    {
        if (year == 1918)
        {
            // Special case: Transition year (1918)
            return "26.09.1918";
        }
        else if ((year < 1918 && year % 4 == 0) || 
            (year > 1918 && ((year % 400 == 0) || 
            (year % 4 == 0 && year % 100 != 0))))
        {
            // Leap year (Julian calendar or Gregorian calendar after 1918)
            return $"12.09.{year}";
        }
        else
        {
            // Non-leap year
            return $"13.09.{year}";
        }
    }
}