using System;

namespace Array
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
            myList.Reverse();
            myList.Remove(30);
            myList.Removeat(0, 2);
            foreach(int a in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
