using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace calculator
{
    public class calc
    {
        int a, b, sum, product;
        public void getadd(int a, int b)
        {
            this.a = a;
            this.b = b;
            sum = a + b;
            Console.WriteLine("sum is:"+sum);  
        }
        public void sub(int a,int b)
        {
            this.a = a;
            this.b = b;
            sum = a - b;
            Console.WriteLine("subtract value is:" + sum);
        }

        public void getproduct(int a, int b)
        {
            this.a = a;
            this.b = b;
            product = a * b;
            Console.WriteLine("product is:" + product);
        }
    }
}
