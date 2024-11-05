using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
      class MyLinkedList<T>
    {
        public Node<T> First {  get; set; }
        public MyLinkedList() { }
        public MyLinkedList(Node<T> first)
        { 
         this.First = first;
        }
        public void Print()
        {
            for(Node<T> i=First ; i!=null ; i=i.Next)
            {
                Console.WriteLine(i.Data);
            }
        }
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Console.WriteLine("the value " + data + " has been added at Last");
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> temp = First; // start from the beggning

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
            public void AddFirst(T data)
            {
            Node<T> newNode= new Node<T>(data);
            Console.WriteLine("the value" + data + "has been added at First");
             newNode.Next = First;
            First = newNode;
            }
        public void AddAtPosition(int position, T data)
        {
            if (position == 0)
            {
                AddFirst(data);
            }
            if (position < 0)
            {
                Console.WriteLine("there is no position like that");
            }
            else
            {
                Node<T> newnode = new Node<T>(data);
                Node<T> temp = First;
                for (int i = 0; i < position - 1; i++)
                {
                    if (temp == null || temp.Next == null)
                    {
                        Console.WriteLine(position);
                        temp = temp.Next;
                    }
                    newnode.Next = temp.Next;
                    temp.Next = newnode;
                    return;
                }
                
            }
        }
        public void DeleteFirst()
            { if (First == null)
                Console.WriteLine("the list is empty");
                First = First.Next;
            
        }
        public void DeleteLast()
        {
           if (First == null)
           Console.WriteLine("the list is empty");

           if(First.Next ==  null)
           {
             First = null;
           }
           else 
           {
             Node<T> temp = First;
                while (temp.Next.Next != null)
                {
                   temp = temp.Next;
                }
                temp.Next = null;
           }
        }
      }
      
}

