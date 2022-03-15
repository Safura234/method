using System;

namespace solution_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 4;
            //int num2 = num;
            //num2 = 5;
            //Console.WriteLine(num);
            //int num = 5;
            // ChangeNum(num);
            // Console.WriteLine($"outside {num}");
            int[] numbers = { 1, 2, 3 };
            ChangeIndex(numbers);
            Console.WriteLine($"outside{numbers[0]}");
        }
        static void ChangeNum(int n)
        {
            n = 10;
            Console.WriteLine($"method {n}");
        }
        static void ChangeIndex(int [] arr)
        {
            arr[0] = 10;
            Console.WriteLine($"method{arr[0]}");
            string word = "Hello";
            string word2 = word;
            word2 = "hi";
            Console.WriteLine(word);

        }
      
        }
        
        
              

    }

