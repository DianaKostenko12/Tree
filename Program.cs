using System;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root.Children.Add(new Node());
            Console.WriteLine();
        }
    }
}
