using System;



namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fetching csv from txt file
            Console.WriteLine("******Fetching csv from txt file*******");
            string[] arr = Fetch.FetchData();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***Filtering****");

            Filtering filtering = new Filtering();
            filtering.FelterData();

            Console.WriteLine("*****Sum/Avg/Min/Max*****");
            Aggrgate.AgriFun();
        }
    }
}
