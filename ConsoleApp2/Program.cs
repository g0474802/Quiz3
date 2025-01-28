using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 Numbers");//to prompt user to input 3 numbers
            int number1 = Convert.ToInt32(Console.ReadLine());//input for number 1
            int number2 = Convert.ToInt32(Console.ReadLine());//input for number 2
            int number3 = Convert.ToInt32(Console.ReadLine());//input for number 3

            if (number1 > number2)//to 
            {
                Console.WriteLine(number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine(number2);
            }
            else if (number2 < number3)
            {
                Console.WriteLine();
            }
        }
    }
}
