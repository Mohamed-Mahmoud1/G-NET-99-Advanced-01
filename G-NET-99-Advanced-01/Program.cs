namespace G_NET_99_Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            //Answer:A generic class allows you to define a class without specifying the data types of its members, letting you specify the type when you instantiate or use the class,
            //use when To achieve type safety and reusability without performance overhead avoiding boxing/unboxing.
            #endregion

            #region Q2
            //Q2:Write a generic class Container<T> with Add and Get methods.
            //Container<int> container = new Container<int>(20);
            //Console.WriteLine($"Value Of Generic Class:{container.Value}");
            #endregion

            #region Q3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //Answer:Multiple type parameters allow you to define different data types for class members when you use them.
            //Pair<char, int> pair = new Pair<char, int>('A',95);
            //Console.WriteLine($"Key:{pair.key}\nValue:{pair.Value}");
            #endregion
        }
    }
}
