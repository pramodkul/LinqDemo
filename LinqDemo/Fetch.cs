using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LinqDemo
{
    class Fetch
    {
       public static string[] FetchData()
        {
            string read = File.ReadAllText(@"D:\Assignment\linq\demoData.txt");
            string[] chunk = read.Split(",");
            return chunk;
        }
    }
}
