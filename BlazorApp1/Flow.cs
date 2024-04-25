namespace BlazorApp1.Interfaces
{
    public partial class Flow : IFlow
    {
        private readonly List<INode> _nodes = new List<INode>();

        public void AddNode(INode node)
        {
            _nodes.Add(node);
        }

        public void ExecuteFlow()
        {
            foreach (var node in _nodes)
            {
                node.Execute();
            }
        }
       public Flow(Action<String> varAction) { }
        public Flow() { }
    }

}
