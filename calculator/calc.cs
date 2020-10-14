using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class calc
    {
        int a, b, sum;
        public void getadd(int a, int b)
        {
            this.a = a;
            this.b = b;
            sum = a + b;
            Console.WriteLine("sum is:"+sum);  
        }

    }
}
