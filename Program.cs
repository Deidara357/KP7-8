using System;
using System.Diagnostics;

namespace КП7
{
    class Program
    {
        class Node
        {
            public Node() { }
            public Node(int Value)
            {
                this.Value = Value;
            }
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
        class BinaryTree
        {
            public Node Root { get; set; }
            public Node Find(int value, Node parent)
            {
                if (parent != null)
                {
                    Console.WriteLine(parent.Value);
                    if (value == parent.Value) return parent;
                    if (value < parent.Value)
                    {
                        if (parent.Left is null)
                        {
                            parent.Left = new Node(value);
                            Console.WriteLine($"{value}   N E W (left)");
                            return parent.Left;
                        }
                        return Find(value, parent.Left);
                    }
                    else
                    {
                        if (parent.Right is null)
                        {
                            parent.Right = new Node(value);
                            Console.WriteLine($"{value}   N E W (right)");
                            return parent.Right;
                        }
                        return Find(value, parent.Right);
                    }
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            var Tree = new BinaryTree();
            var root = Tree.Root;
            root = new Node(50);
            root.Right = new Node(70);
            root.Right.Right = new Node(90);
            root.Right.Left = new Node(60);
            root.Right.Left.Right = new Node(65);
            root.Right.Right.Right = new Node(100);
            root.Right.Right.Right.Left = new Node(95);
            root.Right.Left.Right.Right = new Node(67);
            root.Right.Left.Right.Left = new Node(63);

            root.Left = new Node(30);
            root.Left.Right = new Node(40);
            root.Left.Left = new Node(20);
            root.Left.Left.Left = new Node(10);
            root.Left.Left.Left.Left = new Node(5);
            root.Left.Left.Left.Right = new Node(16);

            Console.WriteLine("Введiть шукану потужнiсть приладу");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine("Шлях знайдено!");
            //Stopwatch timer = new Stopwatch();
            //timer.Start();
            Tree.Find(power, root);
            //timer.Stop();
            //Console.WriteLine($"Час в мiлiсекундах: {timer.ElapsedMilliseconds}");
            Console.WriteLine("Робот живий!");

            Console.ReadKey();
        }
    }
}
