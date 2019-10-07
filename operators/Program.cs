using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a += 10;


            Console.WriteLine(a);

            
            Console.WriteLine(a /= 2);

            a *= 3;

            Console.WriteLine(a);

            int x = 101;
            bool result = x != 100;

            Console.WriteLine(x != 100);
            int v = 20;

            Console.WriteLine(22 < v);

            Console.WriteLine(2 > v);

            Console.WriteLine(11 >= 11);

            //int num = 2;

            bool r = !(!(!(2 != 2 || 2 > 10 || 2 < 200)));

            Console.WriteLine($"Logical OR ||: {r}");

            bool b = !(2 == 2 && 2 < 10 && 2 > 200);

            Console.WriteLine($"Logical AND &&:{b}");

            var age = 25;
            var ager = (age > 25 && age == 25) || (age > 24 && 21 < age) ? true : false;
            Console.WriteLine(ager);

            Console.ReadKey();
        }
    }
}
