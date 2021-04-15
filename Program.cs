using System;
//using System.Collections.Generic.LinkedList<T>;
using System.Collections.Generic;
using System.Text;

///<code logic>
///Create an empty array of size 5
///Iterate from beginning of list and store each value into array
///Wrap around the array and rewrite values when it fills
///When end of list is reached, don't rewrite the array value
///That value is the fifth from the end(including the last value in the list)
///</code logic>

namespace Assessment2
{
    internal class List
    {        
        /// <summary>
        /// Node class
        /// </summary>
        internal class Node
        {
            private int data; 
            private Node next = null;

            /// <summary>
            /// Pointer to next node.
            /// </summary>
            internal Node Next
            {
                get { return next; }
                set { next = value; }
            }
                       
            /// <summary>
            /// Data stored in the node.
            /// </summary>
            internal int Data
            {
                get { return data; }
                set { data = value; }
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="d"></param>
            internal Node(int d)
            {
                data = d;
            }
        }

        private int _length;
        private Node _head;

        /// <summary>
        /// Length of the list
        /// </summary>
        internal int Length
        {
            get { return _length; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        internal List()
        {
            _length = 0;
            _head = null;
        }

        /// <summary>
        /// Display all nodes.
        /// </summary>
        internal void ShowNodes()
        {
            // Print all nodes till the end of the list.
            Node current = _head;
            if (current == null)
            {
                Console.WriteLine("No more nodes to display.");
                Console.WriteLine();
            }
            else
            {
                ShowLength();
                while (current != null)
                {
                    Console.WriteLine("Node : " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Show length of the list.
        /// </summary>
        internal void ShowLength()
        {
            string numString = "numbers";
            if (_length == 1)
            {
                numString = "number";
            }
            Console.WriteLine(String.Format("List has [{0}] {1}.", _length.ToString(), numString));
        }

        /// <summary>
        /// To insert a new Node at the end of the list.
        /// </summary>
        /// <param name="d"></param>
        internal void Add(int d)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Add node [{0}].", d.ToString()));
            // Create a new Node instance with given data;
            Node newNode = new Node(d);
            Node current = _head;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                // Traverse till the end of the list....
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Add new node as the next node to the last node.
                current.Next = newNode;
            }
            _length++;
            ShowNodes();
        }//add

       int[] array1 = new int[5]; //array to keep track of values
       
        /// <summary>
        /// Gets fifth from last item in the list.
        /// </summary>
        internal void getFifthFromLastInt()
        {
            int i = 0;
            
            Node current = _head;
            if (_head == null)
            {
                 Console.WriteLine("List is empty.");
            }
           
            else
            {
                // Traverse till the end of the list....
                while (current.Next != null)
                {
                    array1[i] = current.Data;
                    current = current.Next;                    
                    //Console.WriteLine(String.Format("Add node [{0}].", array1[i]));
                    if(i==4)
                    {
                        i=0;
                    }
                    i++;
                }
                //without overwriting the value, the last iterated over value in the array is our answer
                 Console.WriteLine(String.Format("Get fifth value from last: [{0}].", array1[i]));

            }//else
        }//getFifthFromLast
    }
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            // Add a few elements to the list.
            list.Add(5);
            list.Add(8);
            list.Add(9);
            list.Add(1);
            list.Add(2);
            list.Add(7);

            list.getFifthFromLastInt();
        }
    }
}
