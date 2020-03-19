using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 3, 5, 6, 7, 8, 7, -7, 0 }; // 6 ��������, 4 ������
            int[] b = a;

            Console.WriteLine("������ � A: " + Count(a, true));
            Console.WriteLine("�������� � B: " + Count(b, false));
            Console.ReadKey();
        }

        static int Count(int[] array, bool chet)
        {
            int result = 0;

            foreach (int i in array)
                if (i % 2 == 0)
                    result++;

            if (chet)
                return result;
            else
                return array.Length - result;
        }
    }
}