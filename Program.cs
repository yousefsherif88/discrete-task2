using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, n1, n2, n3;
            Console.WriteLine("Enter value for number 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for number 2 : ");
           n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Prime number between {0} and {1} are : \n", n1, n2);

            for (num = n1; num <= n2; num++)
            {
                n3 = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        n3++;
                        break;
                    }
                }

                if (n3 == 0 && num != 1)
                    Console.Write(" {0} ", num);
               
            }
            Console.Write("\n");
            Console.ReadLine();


        }
    }
}
