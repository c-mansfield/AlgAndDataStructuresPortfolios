using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> testList = new LinkListGen<int>();
            testList.AddItem(21);
            testList.AddItem(152);
            testList.AddItem(65);
            testList.AddItem(4);
            testList.AddItem(192);
            testList.AddItem(95);
            testList.AddItem(21);


            Console.WriteLine("Test List = " + testList.DisplayList());
            Console.WriteLine("Number of items in list = " + testList.NumberOfItems());
            Console.WriteLine("Is 152 present = " + testList.IsPresentItem(152));
            Console.WriteLine("Is 283 present = " + testList.IsPresentItem(283));
            testList.RemoveItem(192);
            testList.RemoveItem(12);
            testList.RemoveItem(21);
            Console.WriteLine("Removed items 192, 12, 21 = " + testList.DisplayList());
            testList.AppendItem(27);
            testList.AppendItem(64);
            Console.WriteLine("Append items 27, 64 = " + testList.DisplayList() + "\n");

            LinkListGen<int> testList2 = new LinkListGen<int>();
            testList2.AddItem(22);
            testList2.AddItem(44);
            testList2.AddItem(66);
            Console.WriteLine("Before Concat: " + testList.DisplayList());
            testList.Concat(testList2);
            Console.WriteLine("After Concat: " + testList.DisplayList() + "\n");

            LinkListGen<int> testList3 = new LinkListGen<int>();
            Console.WriteLine("Before copy: " + testList3.DisplayList());
            testList3.Copy(testList);
            Console.WriteLine("After copy: " + testList3.DisplayList() + "\n");

            LinkListGen<int> testList4 = new LinkListGen<int>();
            testList4.AddItem(9);
            testList4.AddItem(7);
            testList4.AddItem(5);
            testList4.AddItem(3);
            Console.WriteLine("Before Insert: " + testList4.DisplayList());
            testList4.InsertInOrder(8);
            Console.WriteLine("After Insert: " + (testList4.DisplayList() + "\n"));


            LinkListGen<int> testList5 = new LinkListGen<int>();
            testList5.AddItem(24);
            testList5.AddItem(63);
            testList5.AddItem(12);
            testList5.AddItem(97);
            testList5.AddItem(43);
            testList5.AddItem(6);
            testList5.AddItem(85);
            Console.WriteLine("Before Sort: " + testList5.DisplayList());
            testList5.Sort();
            Console.WriteLine("After Sort: "  + testList5.DisplayList());

            Console.ReadKey();
        }
    }
}
