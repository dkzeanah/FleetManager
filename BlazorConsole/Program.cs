using CustomMSBuildTask;

namespace BlazorConsole
{
    // Defining an interface
    interface IExampleInterface
    {
        void InterfaceMethod();
    }

    // Defining a delegate type
    delegate void ExampleDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating object type
            object obj = new ExampleClass();
            Console.WriteLine("Object type: " + obj.GetType().Name);

            // Demonstrating dynamic type
            dynamic dyn = 5;
            Console.WriteLine("Dynamic type before change: " + dyn);
            dyn = "Dynamic type after change";
            Console.WriteLine(dyn);

            // Demonstrating string type
            string str = "Hello, World!";
            Console.WriteLine("String type: " + str);

            // Demonstrating array type
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array type: " + array.GetType().Name);

            // Demonstrating delegate type
            ExampleDelegate del = DelegateMethod;
            del("Delegate call");

            // Demonstrating interface implementation
            IExampleInterface exampleInterface = new ExampleClass();
            exampleInterface.InterfaceMethod();

            // seam 

            Console.WriteLine("C# Type Class System Demonstration\n");

            // Demonstrating IEnumerable
            Console.WriteLine("1. Demonstrating IEnumerable");
            IEnumerable<int> enumerable = Enumerable.Range(1, 10);
            foreach (var item in enumerable)
            {
                Console.Write(item + " "); // Iterating over the range
            }
            Console.WriteLine("\nIEnumerable allows iteration over a collection.\n");

            // Demonstrating ICollection
            Console.WriteLine("2. Demonstrating ICollection");
            ICollection<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            collection.Add(6); // Adding an item
            collection.Remove(3); // Removing an item
            Console.WriteLine($"Count: {collection.Count}");
            foreach (var item in collection)
            {
                Console.Write(item + " "); // Iterating over the collection
            }
            Console.WriteLine("\nICollection allows addition, removal, and iteration.\n");

            // Demonstrating IQueryable
            Console.WriteLine("3. Demonstrating IQueryable");
            IQueryable<int> queryable = collection.AsQueryable().Where(x => x > 2);
            foreach (var item in queryable)
            {
                Console.Write(item + " "); // Iterating over the query result
            }
            Console.WriteLine("\nIQueryable allows querying a collection with LINQ.\n");

            // Demonstrating Boxing and Unboxing
            Console.WriteLine("4. Demonstrating Boxing and Unboxing");
            int val = 10;
            object boxed = val; // Boxing
            int unboxed = (int)boxed; // Unboxing
            Console.WriteLine($"Boxed value: {boxed}, Unboxed value: {unboxed}");
            Console.WriteLine("Boxing is wrapping a value type into an object. Unboxing is extracting it back.\n");

            Console.WriteLine("End of demonstration.");
            Console.ReadLine();
        }
        static void DelegateMethod(string message)
        {
            Console.WriteLine("Called from delegate: " + message);
        }
        class ExampleClass : IExampleInterface
        {
            public void InterfaceMethod()
            {
                Console.WriteLine("Method from interface implementation");
            }
        }
    }
}
