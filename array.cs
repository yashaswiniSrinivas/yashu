using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class array
    {
        public static void Main()
        {
            string searchfor;
            int index;
            string[] fruits = new string[3];
            fruits[0] = "apple";
            fruits[1] = "mango";
            fruits[2] = "grape";
            Console.WriteLine("enter the fruit to be searched");
            searchfor = Console.ReadLine();
            bool result = fruits.Contains(searchfor);
            index = Array.IndexOf(fruits, searchfor);
            Array.Sort(fruits);

            if (result)
                Console.WriteLine($"{searchfor} is found at {index}");
            else
                Console.WriteLine($"{searchfor} is not found ");
            Console.WriteLine("the sorted array is");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);
        }
    }
}
