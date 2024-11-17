using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Letters
    {
        static void Main()
        {
            Console.WriteLine("Enter the Name:");
            var input = Console.ReadLine();
            List<string> words = input.Split(' ').ToList();

            var RequiredName = words.Where(word => word.StartsWith("a") && word.EndsWith("m")).ToList();

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in RequiredName)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
