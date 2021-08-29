using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 5-digit number:");
            string inputNumber = Console.ReadLine();
            int number = Convert.ToInt32(inputNumber);
            int max = 0;
            int min = 9;
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;

            if ((number > 0) && (number < 100000))
            {
                number1 = (number / 10000) % 10;
                Console.WriteLine("1 number is " + (number1));
                number2 = (number / 1000) % 10;
                Console.WriteLine("2 number is " + (number2));
                number3 = (number / 100) % 10;
                Console.WriteLine("3 number is " + (number3));
                number4 = (number / 10) % 10;
                Console.WriteLine("4 number is " + (number4));
                number5 = (number % 10);
                Console.WriteLine("5 number is " + (number5));

                int[] array1 = new int[] { number1, number2, number3, number4, number5 };

                for (int i = 0; i < 5; i++)
                {
                   if ((array1[i] > max)|| (array1[i] == max))
                    {
                        max = array1[i];
                    }
                   if ((array1[i] < min) || (array1[i] == min))
                    {
                        min = array1[i];
                    }
                }
                Console.WriteLine("The biggest number is " + max);
                Console.WriteLine("The smallest number is " + min);
            }
            else
            {
                Console.WriteLine("Your input is incorrect");
            }

       

        }
    }
}
