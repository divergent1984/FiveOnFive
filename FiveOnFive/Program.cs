using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveOnFive
{
    class Program
    {
        static void Main(string[] args)
        {
            // просим пользователя ввести число с окончанием 5.
            Console.WriteLine("Введите число заканчивающееся на 5");
            string nam = Console.ReadLine();
            string s = nam;
            //берем длину строки и отнимаем последний символ.
            int nam2 = nam.Length - 1;
            nam = nam.Remove(nam2);
            //конвентируем в инт и добавляем 1.
            int Sum=Convert.ToInt32(nam)+1;
            //умножаем полученный результат на число пользователя.
            int Sqrt =Convert.ToInt32(nam) * Sum;
            //конвектируем полученное число в строку и добавляем 25.
            String Sum2 = Convert.ToString(Sqrt) +"25";
            Console.WriteLine(s +" " +" "+ "в квадрате" + "=" + Sum2);

            Console.ReadKey();
        }
    }
}
