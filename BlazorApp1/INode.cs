namespace BlazorApp1.Interfaces
{
    using System.Collections.Generic;

    // Defines the basic structure of a node in an ETL flow.
    public interface INode
    {
        void Execute();
    }

    // Defines the structure of an ETL flow, which is a collection of nodes.


}
