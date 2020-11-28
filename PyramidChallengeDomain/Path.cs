using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PyramidChallengeDomain
{
    public class Path : Collection<Node>
    {
        public int GetTotalWeight() => this.Sum(item => item.Weight);

        public override string ToString() => string.Join(", ", Items.Select(item => item.Weight));

        public Path()
        {
        }

        public Path(List<Node> nodes)
        {
            nodes.ForEach(n => Items.Add(n));
        }

        public Path(Path path)
        {
            foreach (var node in path.Items)
                Items.Add(node);
        }
    }
}
