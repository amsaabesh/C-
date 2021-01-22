using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List
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
            myList.RemoveAt(1);
            foreach (int a in myList)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
