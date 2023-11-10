using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ha_linklist
{
    public class LinkedList
    {
        private Node head;

        public void Add(string item)
        {
            Node NewNode = new Node(item); // item is input, input makes a new instance of node.

            if (head == null || string.Compare(item, head.Data, StringComparison.OrdinalIgnoreCase) < 0) // head == null checks if the currentlist is currently empty
            {  // Cecks the first letter of the input, to see where the instance would go on the list.
                NewNode.Next = head;
                head = NewNode;
            }
            else // finds the correct position of the new node should be in
            {
                Node Current = head; // binds the item to a temp current node
                while (Current.Next != null && string.Compare(item, Current.Next.Data, StringComparison.OrdinalIgnoreCase) > 0)
                { // Checks if new node should be inserted before or affer the current.Next base on a case insensitive alphabetical order.
                    Current = Current.Next;
                }
                NewNode.Next = Current.Next; // insert after finding the correct positon
                Current.Next = NewNode;
            }
        }

        public bool Remove(string item)
        {
            if (head == null)
                return false; // checks if the list is currently empty, if it is, it returns a false

            if (string.Equals(head.Data, item, StringComparison.OrdinalIgnoreCase)) // checks if if item is on the list, to remove it 
            {
                head = head.Next;
                return true;
            }

            Node Current = head;
            while (Current.Next != null && !string.Equals(Current.Next.Data, item, StringComparison.OrdinalIgnoreCase)) 
            { // Looks through the list to find the node with the specified item
                Current = Current.Next;
            }

            if (Current.Next == null)
                return false; // Checks if the end of the while loop is reach without finding the item

            Current.Next = Current.Next.Next; //removes the node that's holding the specified item
            return true;
        }

        public bool Search(string item)
        {
            Node Current = head;
            while (Current != null)
            {
                if (string.Equals(Current.Data, item, StringComparison.OrdinalIgnoreCase)) // Compares case insensitive chick if the current matches with specified item
                    return true;
                Current = Current.Next;
            }
            return false;
        }

        public void PrintAll()
        {
            Node Current = head;
            while (Current != null)
            {
                Console.WriteLine(Current.Data); // Prints all nodes
                Current = Current.Next;
            }
        }
    }
}
