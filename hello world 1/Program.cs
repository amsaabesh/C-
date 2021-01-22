using System;

namespace hello_world_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(30);
            myList.Add(230);
            myList.Add(330);
            myList.Add(301);
            myList.Add(235);
            Console.WriteLine(myList.Count);
        }
    }
}
