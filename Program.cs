using System;
using System.Linq;
using System.Collections.Generic;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
                {

            string[] num = new string[10];

            int num1 = 34;
            int num2 = 5;
            int num3 = 67;
            int num4 = 1;
            int num5 = 99;
            int num6 = 34;
            int num7 = 44;
            int num8 = 78;
            int num9 = 34;
            int num10 = 0;

            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 ;

            

            for( int counter = 0; counter < 1; counter++ )
            {
             
             System.Console.WriteLine( num1 + "+" +  num2 + "+" + num3 + "+" + num4 + "+" + num5 + "+" + num6 + "+" + num7 + "+" + num8 + "+" + num8 + "+" + num9 + "+" + num10+ "=");
             Console.WriteLine(sum);

            }             
        
          
       }
    }
}
