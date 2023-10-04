//Практическая работа номер 8
//Выполнил Мелехов И.В
//Создать программу использования алгоритма с применением итерационных циклических структур
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Нажмите Y чтобы продолжить или N чтобы прекратить: ");
                Console.Clear();
                bool flag = false;
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.WriteLine("Практическая работа номер 8.\nЗдравствуйте!");
                            long N;
                            try
                            {
                                Console.Write("\tВведите целое число N=");
                                N = Int32.Parse(Console.ReadLine());
                                if (N < 0)
                                {   
                                    Console.ForegroundColor= ConsoleColor.Red;
                                    Console.WriteLine("Введено отрицательное знаечние");
                                    flag = true;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                long n = 1;
                                int i;
                                if (N % 2 == 0) i = 2;                                                               
                                else i = 1;                                                              
                                while (i <= N)                                
                                    n *= i;
                                    i += 2;                                
                                if (!flag) Console.WriteLine($"двойной факториал {N} = {n}");
                                    Console.WriteLine("Нажмите Y чтобы продолжить или N чтобы прекратить: ");                             
                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Введено недопустимое значение " + fe.Message);
                            }

                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Произошла какая то ошибка" + e.Message);
                        }
                        break;
                    case "N":
                        Environment.Exit(0);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("До свидания");
                        break;
                }
            }
        }
    }
}
