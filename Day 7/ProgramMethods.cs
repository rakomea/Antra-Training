using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ProgramMethods
    {
        public void ReverseArray(int[] inPutArr)
        {
            for(int i = 0; i < inPutArr.Length/2 ; i++)
            {
                int a = inPutArr[i];
                int b = inPutArr[inPutArr.Length - 1 - i];
                int temp;
                temp = a;
                a = b;
                b = temp;
            }
        }

        public int fib(int n)
        {
            int[] fibArr = new int[n + 2];
            int i;

            /* 1st and 2nd number of the
               series are 0 and 1 */
            fibArr[0] = 0;
            fibArr[1] = 1;

            for (i = 2; i <= n; i++)
            {
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
            }

            return fibArr[n];
        }
        
        public class Date {
        public int d, m, y;
 
        public Date(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }
    };
 
    // To store number of days in
    // all months from January to Dec.
    static int[] monthDays = { 31, 28, 31,
                               30, 31, 30,
                               31, 31, 30,
                               31, 30, 31 };
 
    // This function counts number of
    // leap years before the given date
    static int countLeapYears(Date d)
    {
        int years = d.y;
 
        // Check if the current year
        // needs to be considered
        // for the count of leap years or not
        if (d.m <= 2) {
            years--;
        }
 
        // An year is a leap year if it is
        // a multiple of 4, multiple of 400
        // and not a multiple of 100.
        return years / 4
               - years / 100
               + years / 400;
    }
 
    // This function returns number
    // of days between two given dates
    static int getDifference(Date dt1, Date dt2)
    {
        // COUNT TOTAL NUMBER OF DAYS
        // BEFORE FIRST DATE 'dt1'
 
        // initialize count using years and day
        int n1 = dt1.y * 365 + dt1.d;
 
        // Add days for months in given date
        for (int i = 0; i < dt1.m - 1; i++)
        {
            n1 += monthDays[i];
        }
 
        // Since every leap year is of 366 days,
        // Add a day for every leap year
        n1 += countLeapYears(dt1);
 
        // SIMILARLY, COUNT TOTAL
        // NUMBER OF DAYS BEFORE 'dt2'
        int n2 = dt2.y * 365 + dt2.d;
        for (int i = 0; i < dt2.m - 1; i++)
        {
            n2 += monthDays[i];
        }
        n2 += countLeapYears(dt2);
 
        // return difference between two counts
        return (n2 - n1);
    }
 
    }
}
