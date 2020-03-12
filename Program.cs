using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArrayConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[10];          
            int EvenCount = 0, OddCount = 0;  
            Console.Write( "Enter the array elements: " );

            for (int i = 0; i <= (arrayElements.Length - 1); i++)
            {
                arrayElements[i] = Convert.ToInt32(Console.ReadLine());
                if (arrayElements[i] % 2 == 0)
                {
                    EvenCount ++;
                }
                else if (arrayElements[i] % 2 != 0)
                {
                    OddCount ++;                  
                }               
            }
            Console.Write( "Even elements in array is: " + EvenCount);          
            Console.Write( "Odd elements in array is: " + OddCount);
            Console.ReadLine();

        }
    }
}
