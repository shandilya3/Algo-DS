using System;

namespace ConsoleApplication
{
        public class Node
        {
            public int data;
            public Node next;
        }
        public class Queue
        {
            public  Node head= null;
             public Node tail = null;
            // to enque , we  put at the end of the queue
            public void Enqueue(int x)
            {
                if(head==null && tail ==null)
                {
                    tail=new Node{data=x};
                    head=tail;
                    Console.WriteLine(head + "head come here frst");
                }
                else
                {
                   tail.next=new Node {data=x};
                   tail=tail.next;
                }     
            }
            // to dequeu we remove from the start 
                public void Dequeue()
                {
                    if(head == null || tail == null)
                    {
                        Console.WriteLine("there is no item");
                    }
                    else if ( head == tail)
                    {
                      head=tail=null;
                    }
                    else{
                        head=head.next;
                    }
                }
                public void PrintQueue()
                {
                    Node temp=head;
                    while(temp!=null)
                    {
                        Console.WriteLine(temp.data + "->");
                        temp=temp.next;
                    }
                }
                 public static void Main(string[] args)
                    {
                            Console.WriteLine("Hello World!");
                            Queue obj = new Queue();
                            obj.Enqueue(10);
                            obj.PrintQueue();
                            Console.WriteLine("head's Value "+obj.head.data);
                            obj.Enqueue(11);               
                             obj.Enqueue(13);
                             obj.PrintQueue();
                             Console.WriteLine("After dequeu operation check the queue");
                             obj.Dequeue();
                             obj.PrintQueue();
                    }
         }
      
       
 }

