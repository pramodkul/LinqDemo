using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class Filtering
    {
        public void FelterData()
       {

        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var list = numbers.Where(x => x > 2);



            object[] obj = new object[] { 2, "Ashu", 56, 67.89m, "Light" };

            // or query
            
            var res1 = from num in numbers where num > 3 select num;

            // ofType

            var ofType = obj.OfType<string>();

            var res = obj.OfType<int>();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            foreach (var item in ofType)
            {
                Console.WriteLine(item);
            }
        }
    }
}
