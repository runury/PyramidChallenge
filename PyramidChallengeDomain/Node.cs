using System;
using System.Collections.Generic;
using System.Linq;

namespace PyramidChallengeDomain
{
    public class Node
    {
        public Path PathToNode { get; set; }

        public List<Node> Children { get; private set; }

        public int Weight { get; private set; }

        public bool IsBottomNode { get; set; }

        public Node(int weight)
        {
            Weight = weight;
            Children = new List<Node>();
        }

        public void AddChild(Node node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            Children.Add(node);
            Children = Children.OrderByDescending(n => n.Weight).ToList();
        }
    }
}
