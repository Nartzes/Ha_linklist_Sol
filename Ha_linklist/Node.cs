using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha_linklist
{
    public class Node
    {
        public string Data { get; set; } // capture input data
        public Node Next { get; set; } // creates node

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
