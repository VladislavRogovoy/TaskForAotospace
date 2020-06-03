using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var sortMas = from t in mas
                      where t % 2 == 0
                      select t;

            int sum = sortMas.Sum();

            Console.WriteLine(@"sum of odd numbers {0}", sum.ToString());

            RemoveDublicateNumbers();
            RemoveOddNumbers();

            Console.ReadLine();
        }

        public static void RemoveDublicateNumbers()
        {
            string str = "aabbkenyiiinosii";
            Console.WriteLine(str);
            int i = 0;
            while (true)
            {
                var tmp = str[i].ToString();
                str = str.Replace(tmp, "");
                str = str.Insert(i, tmp);
                i++;
                if (str.Length - 1 < i)
                    break;
            }
            Console.WriteLine(str);
        }

        public static void RemoveOddNumbers()
        {
            List<int> numbers = new List<int>(Enumerable.Range(1, 50));

            for (int i = 0; i< numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
