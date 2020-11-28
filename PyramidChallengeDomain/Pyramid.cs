using System;
using System.Collections.Generic;
using System.Linq;

namespace PyramidChallengeDomain
{
    public class Pyramid
    {
        public Node Root { get; private set; }

        public List<Node> Nodes { get; private set; }

        public Pyramid(int[] inputWeights)
        {
            if (inputWeights == null || inputWeights.Length == 0)
                throw new ArgumentException("Invalid input");

            Nodes = new List<Node>();

            BuildPyramid(inputWeights);
        }

        #region Get longest path

        public Path GetLongestPath()
        {
            var nodes = GetNodePaths(Root, new Path(), new List<Node>()).Where(node => node.IsBottomNode);

            if (!nodes.Any())
                return new Path();

            return nodes.OrderByDescending(node => node.PathToNode.GetTotalWeight()).First().PathToNode;
        }

        private List<Node> GetNodePaths(Node root, Path path, List<Node> visitedNodes)
        {
            path.Add(root);

            if (visitedNodes.Contains(root))
            {
                if (path.GetTotalWeight() > visitedNodes.Find(x => x == root).PathToNode.GetTotalWeight())
                {
                    root.PathToNode = path;
                    root.Children.ForEach(child => GetNodePaths(child, new Path(path), visitedNodes));
                }
            }
            else
            {
                root.PathToNode = path;
                visitedNodes.Add(root);
                root.Children.ForEach(child => GetNodePaths(child, new Path(path), visitedNodes));
            }

            return visitedNodes;
        }

        #endregion

        #region Graph composition

        private void BuildPyramid(int[] inputWeights)
        {
            Nodes = inputWeights.Select(n => new Node(n)).ToList();
            Root = Nodes.First();

            AddRelations();
        }

        private void AddRelations()
        {
            var rowLength = 1;
            var indexInRow = 0;
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes.Count <= i + rowLength)
                {
                    var lastRow = Nodes.Skip(indexInRow == 0 ? i : Nodes.Count - indexInRow).ToList();
                    lastRow.ForEach(n => n.IsBottomNode = true);
                    break;
                }

                indexInRow++;
                AddChild(i, new List<int>() { i + rowLength, i + rowLength + 1});
                
                if(indexInRow == rowLength)
                {
                    rowLength++;
                    indexInRow = 0;
                }
            }
        }

        private void AddChild(int rootIndex, List<int> childIndexes)
        {
            foreach (var childIndex in childIndexes)
                if (Nodes.Count > Math.Max(rootIndex, childIndex) && IsOddEven(Nodes[rootIndex], Nodes[childIndex]))
                    Nodes[rootIndex].AddChild(Nodes[childIndex]);
        }

        private bool IsOddEven(Node node1, Node node2)
        {
            return (Math.Abs(node1.Weight + node2.Weight)) % 2 == 1;
        }

        #endregion
    }
}