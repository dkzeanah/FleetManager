namespace BlazorApp1.Interfaces
{
    public interface IFlow
    {
        void AddNode(INode node);
        void ExecuteFlow();
    }
}
