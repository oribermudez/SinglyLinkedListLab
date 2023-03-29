using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class LinkedList
    {
        public Node? Head { get; set; }

        public ulong Count { get; set; }

        public bool isEmpty
        {
            get => this.Head == null;
        }

        public LinkedList()
        {
            this.Head = null;
        }

        public void AddFirst(string value)
        {
            // Create new node
            Node newNode = new Node();

            // Set value of new node
            newNode.Value = value;

            if (this.isEmpty)
            {
                this.Head = newNode;
            }
            else
            {
                // Get the node at the head
                Node head = this.Head;

                // Set the next of new node to node at head
                newNode.Next = head;

                // Set the head to the new node
                this.Head = newNode;
            }

            // Increment count
            this.Count++;
        }

        public void AddLast(string value)
        {
            // Create new node
            Node newNode = new Node();

            // Set value of new node
            newNode.Value = value;

            // Add to the SLL if head is empty
            if(this.isEmpty)
            {
               this.Head = newNode;
            }
            else
            {
                // Get the last node (loop to node with no next)
                Node lastNode = this.Head;  

                while(lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }

                //Set the next of the last node to newNode
                lastNode.Next = newNode;
            }

            // Increment count
            this.Count++;
        }

        public bool RemoveFirst()
        {

            // Return false if head is empty
            if (this.isEmpty)
            {
                return false;
            }
            else if (this.Count == 1)
            {
                this.Head = null;
            }
            else
            {
                // Get the current node at the head
                Node currentHead = this.Head;

                // Get the next node of the head
                Node newHead = currentHead.Next;

                // Set the head to the newHead node
                this.Head = newHead;
            }

            // Decrement count
            this.Count--;

            return true;
        }

        public bool RemoveLast()
        {

            // Return false if head is empty
            if (this.isEmpty)
            {
                return false;
            }
            else if (this.Count == 1)
            {
                this.Head = null;
            }
            else
            {
                // Loop until the previous node of node to delete
                Node nextNode = this.Head;
                Node previousNode = nextNode;

                while (nextNode.Next != null)
                {
                    previousNode = nextNode;
                    nextNode = nextNode.Next;
                }

                // Set the next of the before last node to null
                previousNode.Next = null;
            }

            // Decrement count
            this.Count--;

            return true;
        }

        public string GetValue(ulong index)
        {

            // Return error message if SLL is empty or index greater than the SLL size
            if (this.isEmpty || index > this.Count)
            {
                return "The index provided does not exists";
            }
            else
            {
                // Loop to get the node in the index provided
                Node nextNode = this.Head;
                ulong count = 1;

                while (count < index)
                {
                    nextNode = nextNode.Next; 
                    count++;
                }

                // Return the value of the node
                return nextNode.Value;
            }
        }
    }
}
