using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node<int> tree = new Node<int>(6);
            tree.Left = new Node<int>(2);
            tree.Left.Right = new Node<int>(5);*/

            Node<int>[] a =
            {
                new Node<int>(5), new Node<int>(10), new Node<int>(20)
            };

            a[0].Left = a[1];
            a[0].Right = a[2];
            //a[1].Left = a[3];
            




            string hold = "";
            BinTree<int> tree = new BinTree<int>(a[0]);
            tree.PreOrder(ref hold);
            Console.WriteLine("Pre-Order = " + hold);

            string hold2 = "";
            tree.InOrder(ref hold2);
            Console.WriteLine("In Order = " + hold2);

            string hold3 = "";
            tree.PostOrder(ref hold3);
            Console.WriteLine("Post Order = " + hold3);

            Console.Read();
        }
    }
}
