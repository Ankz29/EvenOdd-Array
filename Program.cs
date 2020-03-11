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
            int[] Array = new int[10] ;
            int[] EvenElements = new int[5];
            int[] OddElements = new int[5];
            Console.Write( "Enter the array elements: " );
            
            for (int i = 0 ; i< arrayElements.Length ; i++)
            {
              Array[i] = Convert.ToInt32( Console.ReadLine() );
            }

          for(int j=0 ; j<Array.Length; j++)
          {
              if (Array[j] % 2 == 0)
              {
                   EvenElements[j] = Array[j];
              }
              else
              {
                   OddElements[j] = Array[j];
              }
          }
          Console.Write( "Even elements in array is: " + EvenElements );
          Console.ReadLine();

          Console.Write( "Odd elements in array is: " + OddElements );
          Console.ReadLine();

        }
    }
}
