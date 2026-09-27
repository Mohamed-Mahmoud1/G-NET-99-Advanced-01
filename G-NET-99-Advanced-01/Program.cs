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

            #region Q4
            //Q4:What is a generic method? Write Swap<T> method.
            //Answer:A generic method allows you to write a method definition without specifying the method's data types, letting you specify the types when you call or use the method.
            //int number01 = 5;
            //int number02 = 10;
            //SwapHelper.Swap<int>(ref number01, ref number02);
            //Console.WriteLine(number01);
            //Console.WriteLine(number02);

            #endregion

            #region Q5
            //Q5:Write a generic method FindMax<T> that finds maximum value
            //int[] numbers = { 1, 2, 7, 3, 4 };
            //Console.WriteLine(Utility.FindMax(numbers));
            #endregion

            #region Q6
            //Q6:What is a generic interface? Write IRepository<T>.
            //Answer:A generic interface allows you to define an interface without specifying the data types of its members.
            //IRepository<int> repo;
            #endregion

            #region Q7
            //Q7:What is the 'struct' constraint? Write an example.
            //Answer:It allows the generic parameter to accept only value types.
            //Empolyee<double> empolyee = new Empolyee<double>();
            #endregion

            #region Q8
            //Q8:What is the 'class' constraint? Write an example.
            //Answer:It allows the generic parameter to accept only references types.
            //Person<Student> person = new Person<Student>();

            #endregion






        }
    }
}
