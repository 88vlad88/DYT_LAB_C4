/*
11.	Перевірити істинність вислову: "Дане чотиризначне число читається однаково зліва направо і справа наліво". 
*/
using System;

namespace LabOne
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение");
            string s = Console.ReadLine();
            string a = s;
            

            char[] str1 = a.ToCharArray();
            Array.Reverse(str1);
            string aa = String.Concat<char>(str1);
            Console.WriteLine(str1);


            if (aa == s)
            {
                Console.WriteLine("(True) Дане чотиризначне число читається однаково зліва направо і справа наліво");
            }
            else {
                Console.WriteLine("(False)Дане чотиризначне число читається не однаково зліва направо і справа наліво");
            }
            Console.ReadKey();
        }
         
    }
}
