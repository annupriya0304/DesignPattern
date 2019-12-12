using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        public static Node CreateLinkedList()
        {

            Node ll = new Node(10);
            ll.Next = new Node(15);
            ll.Next.Next = new Node(12);
            ll.Next.Next.Next = new Node(13);
            ll.Next.Next.Next.Next = new Node(20);
            ll.Next.Next.Next.Next.Next = new Node(14);

          

            return ll;

        }

        public static void Print(Node ll)
        {
            
            while (ll.Next != null)
            {
                Console.WriteLine(ll.Data);
                ll = ll.Next;
            }

            Console.WriteLine(ll.Data);
        }

        public static void Swap(Node ll, int x, int y)
        {
            
            while (ll.Data != x)
            {
                ll = ll.Next;
                   
            }
            ll.Data = y;
        }
    }

    class Node
    {
      public  int Data;
      public  Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }


      

      

    }




}
