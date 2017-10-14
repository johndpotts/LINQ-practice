using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var lowNumbers =
            //    from n in numbers
            //    where n < 5
            //    select n;

            //foreach (var x in lowNumbers)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadLine();

            //var lowNumbersMethod = numbers.Where(num => num < 5);
            //foreach (var x in lowNumbersMethod)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadLine();


            var d = new Dictionary<string, string>
            {
                {"Buster", "Balls" },
                {"Allie", "Bones" },
                {"Smokey","Bones" },
                {"Mia","Balls" },
                {"Fido","Chewtoys" },
                { "Roscoe", "Beanbag Chairs"}

            };

            var toys =
                from dog in d
                where dog.Key == "Allie"
                select dog.Value;

            foreach (var item in toys)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            var toysMethod = d.Where(toy => toy.Value == "Bones").ToArray();//.Select(toy => toy.Key);

            foreach (var item in toysMethod)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

        }





    }
}
