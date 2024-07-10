using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber, remainderVariable, sum = 0, copyOfInputNumber;
            Console.Write("Enter the Number: ");
            inputNumber = int.Parse(Console.ReadLine());
            copyOfInputNumber = inputNumber;

            while (inputNumber > 0)
            {
                remainderVariable = inputNumber % 10;
                sum = (sum * 10) + remainderVariable;
                inputNumber = inputNumber / 10;
            }

            if (copyOfInputNumber == sum)
                Console.WriteLine(copyOfInputNumber + " is a Palindrome Number.");
            else
                Console.WriteLine(copyOfInputNumber + " is not a Palindrome Number.");
        }
    }
}
