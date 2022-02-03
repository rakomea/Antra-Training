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

    }
}
