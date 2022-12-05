using System;

namespace ConsoleApp2
{
    class Program
    {

        static void f(string n, int i=0, double result=0)
        {
            double slag = 0;
            if (i < n.Length)
            {

                if (n[i] == '1')
                {
                    slag = Math.Pow(2, n.Length - i - 1);
                }
                result += slag;
                f(n, i + 1, result);
            }
            else
            {
                if (n[0] == '-') result = -result;
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число в двоичной системе счисления: ");
            string a = Console.ReadLine();
            int flag = 0;
            foreach (char item in a)
            {
                if(item != '0' && item != '1')
                {
                    Console.WriteLine("Некорректный ввод данных");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                int n = Convert.ToInt32(a[0]);
                f(a);
            }
        }
    }
}
