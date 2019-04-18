using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Plus(451, 251);
            WriteLineRed(result);
            int result2 = Minus(1000, 300);
            WriteLineGreen(result2);
            int result3 = Multiple(5, 5);
            WritelineRed(result3);
            int result4 = Share(2000, 50);
            WriteLineGreen(result4);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadKey();

            Console.WriteLine("Пиши циферку №1");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводите знак операции");
            string sign = Console.ReadLine();
            Console.WriteLine("Пиши циферку №2");
            int secondNumber = int.Parse(Console.ReadLine());

            int result5 = 0;
            Console.WriteLine(result5);
            if (sign == "+")
            {
                Console.WriteLine("slogenie");
                result = firstNumber + secondNumber;
            }
            if (sign == "-")
            {
                Console.WriteLine("vichitanie");
                result = firstNumber - secondNumber;
            }
            if (sign == "*")
            {
                Console.WriteLine("umnogenie");
                result = firstNumber * secondNumber;
            }
            if (sign =="/")
            {
                Console.WriteLine("delenie");
                result = firstNumber / secondNumber;
            }

        }

            static void SetDefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Beep();
        }

            static void WritelineRed(int x)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(x);
            SetDefaultColor();
        }
            static void WriteLineGreen(int x)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(x);
            SetDefaultColor();
        }
            static void WriteLineRed(int x)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(x);
            SetDefaultColor();
        }
            static void Write(string str)
        {
            Console.WriteLine("Vitalik, smotri kak ya himichu");
            Console.WriteLine(str);
            Console.WriteLine("Vo ya psih");
        }

        static int Plus( int numeral1, int numeral2)
        {
            return numeral1 + numeral2;
        }

        static int Minus(int numeral1, int numeral2)
        {
            return numeral1 - numeral2;
        }

        static int Multiple(int numeral1, int numeral2)
        {
            return numeral1 * numeral2;
        }

        static int Share(int numeral1, int numeral2)
        {
            return numeral1 / numeral2;
            
        }
        
            
        
        
            
        

    }
}
