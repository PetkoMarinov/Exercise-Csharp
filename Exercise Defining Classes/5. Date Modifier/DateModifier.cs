using System;
using System.Linq;

namespace _5._Date_Modifier
{
    public class DateModifier
    {
        public string Date1 { get; set; }
        public string Date2 { get; set; }

        public DateModifier()
        {

        }

        public double DaysBetweenTwoDays(string date1, string date2)
        {
            int[] firstDateInfo = date1.Split(' ').Select(int.Parse).ToArray();
            int[] secondDateInfo = date2.Split(' ').Select(int.Parse).ToArray();

            DateTime earlierDate = new DateTime(firstDateInfo[0], firstDateInfo[1], firstDateInfo[2]);
            DateTime secondDate = new DateTime(secondDateInfo[0], secondDateInfo[1], secondDateInfo[2]);

            return Math.Abs((secondDate - earlierDate).TotalDays);
        }
    }
}
