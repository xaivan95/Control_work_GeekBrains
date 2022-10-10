using System;

namespace SelectStringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayString = GetStringArray();
            var result =GetNewStringArray(arrayString);

        }

        static string[] GetStringArray()
        {
            string[] array = new string[0];
            int i = 0;
            while (true)
            {
                Console.WriteLine("Введите новую строку для массива или пустую строку для выхода:");
                var s = Console.ReadLine();
                if (s.Length == 0) return array;
                Array.Resize<string>(ref array, i + 1);
                array[i] = Console.ReadLine();
                i++;
            }
        }
        static string[] GetNewStringArray(string[] array)
        {
            int i = 0;
            string[] result = new string[0];
            foreach (string s in array)
            {
                if (s.Length <= 3)
                {
                    Array.Resize<string>(ref result, i + 1);
                    result[i] = s;
                    i++;
                }
            }
            return result;
        }



    }
}
