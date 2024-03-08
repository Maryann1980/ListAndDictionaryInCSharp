namespace ListAndDictionaryInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Lists and Dictionary in C#....");
            Author author = new Author();
            Console.WriteLine();
            Console.WriteLine("The output of the list are: ");
            author.ManipulationDict();
            Console.WriteLine();
            Console.WriteLine("The output of the dictionary are: ");
            author.ManipulationDict();
        }
    }
}
