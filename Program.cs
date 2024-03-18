using System;

namespace code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of positive integers you want to enter:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

           for (int i = 0; i < number; i++)
           {
                Console.WriteLine($"Enter your {i + 1} number:");
                int figure = int.Parse(Console.ReadLine());
            
                if (figure % 3 == 0 && figure % 2 == 0 && figure >= 0)
                {
                    sum += figure;
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Average of the positive even numbers divisible by 3 entered: {sum / count}");
            }
            else
            {
                Console.WriteLine("No valid numbers entered.");
            }
            




Console.WriteLine("2");

           // number 2
           
            Console.WriteLine("Input your number");
            int num = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
        
            for (int i = 1; i <= num; i++)
            {
                if (i + (i + 1) + (i + 2) == num)
                {
                    firstNum = i;
                    secondNum = i + 1;
                    thirdNum = i + 2;
                    Console.WriteLine($"[{firstNum},{secondNum},{thirdNum}]");
                    return;
                }
            }
            Console.WriteLine("[]");
                


            static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }    
                return n*(n-1);
        }
        static int fibonacci(int n)
        {
            if(n<=1)
            {
                return n;
            }
            else
            return fibonacci(n-1)+fibonacci(n-2);
        }
        }
        
    }


        }
    

