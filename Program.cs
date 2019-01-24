using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework
{
    class Program
    {
        public static int Divide(int firstNumber, int secondNumber)
        {
            if (firstNumber.Equals(null) || secondNumber.Equals(null))
            {
                throw new ArgumentNullException();
            }
            if (secondNumber == 0)
            {
                throw new ArgumentException();
            }
            return firstNumber / secondNumber;
        }

        public static void IndexOutOfArrRange()
        {
            int[] arr = new int[10];
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        static void Main(string[] args)
        {
            int a = 3, b = 0;
            try
            {
                Divide(a, b);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Один из аргументов отсутствует");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Вы пытаетесь поделить на ноль");
            }
            Console.ReadLine();
            Console.Clear();
            try
            {
                IndexOutOfArrRange();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Вы вышли за предел массива");
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }
            Console.ReadLine();
        }
    }
}
