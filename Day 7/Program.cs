using System;
namespace CosoleApp2
{
  ProgramMethod programMethod = new ProgramMethod();
  public static void Main ()
    {
        int n = 9;
        Console.WriteLine(fib(n));
    Date dt1 = new Date(1, 2, 2000);
        Date dt2 = new Date(1, 2, 2004);
       
        // Function call
        Console.WriteLine("Difference between two dates is "
                          + getDifference(dt1, dt2));
    }
}
