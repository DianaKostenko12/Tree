using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public List<Node> Children { get; set; }

        public Node()
        {
            Children = new List<Node>();
        }

        public Node(List<Node> children)
        {
            Children = children;
        }
        
    }
}
