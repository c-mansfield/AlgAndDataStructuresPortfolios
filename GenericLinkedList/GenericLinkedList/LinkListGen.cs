using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> listGen;

        public LinkListGen()
        {
        }
        public void AddItem(T item)
        {
            listGen = new LinkGen<T>(item, listGen);
        }
        public string DisplayList()
        {
            LinkGen<T> temp = listGen;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer = buffer + temp.Data + " ";
                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems()
        {
            LinkGen<T> temp = listGen;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = listGen;
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }
        public void RemoveItem(T item)
        {
            LinkGen<T> temp = listGen;
            LinkGen<T> previous = null;
            T data = temp.Data;
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {
                    if (previous != null)
                    {
                        previous.Next = temp.Next;
                    }
                    else
                    {
                        previous = temp;
                        temp = temp.Next;
                        listGen = temp;
                    }
                }

                previous = temp;
                temp = temp.Next;
            }
        }

        public void AppendItem(T item)
        // Pre: True
        //Post: Item is added at the end of the list contains
        {
            LinkGen<T> temp = listGen;

            if (temp == null)
            {
                listGen = new LinkGen<T>(item);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }

        }

        public void Concat(LinkListGen<T> list2)
        // Pre: True
        //Post: list becomes concatenation of list and list2 e.g. [2,3,4], [6,7,8] = [2,3,4,6,7,8]
        //Hint – easy to write in terms using AppendItem
        {

            LinkGen<T> temp = list2.listGen;

            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }

        }

        public void Copy(LinkListGen<T> list2)
        // Pre: True
        //Post: list contains the same items as in list2
        //Hint – easy to write in terms of Concat
        {
            Concat(list2);
        }

        public void InsertInOrder(T item)
        // Pre: list is in non-descending order – e.g. [3, 5, 10]
        //Post: list contains item inserted in correct place in list
        {
            LinkGen<T> temp = listGen;
            LinkListGen<T> newList = new LinkListGen<T>();

            if (listGen == null)
            {
                AddItem(item);
            }
            else
            {
                while (temp != null && temp.Data.CompareTo(item) == -1)
                {
                    newList.AppendItem(temp.Data);
                    temp = temp.Next; //increments temp
                }

                newList.AppendItem(item);

                while (temp != null && temp.Data.CompareTo(item) == 1)
                {
                    newList.AppendItem(temp.Data);
                    temp = temp.Next; //increments temp
                }
                listGen = newList.listGen;

            }
        }

        public void Sort()
        // Pre: True
        //Post: list contains items in non-descending order
        {
            LinkGen<T> temp = listGen;
            LinkListGen<T> newList = new LinkListGen<T>();

            while(temp != null)
            {
                InsertInOrder(temp.Data);
                temp = temp.Next;
            }

        }
    }



}
