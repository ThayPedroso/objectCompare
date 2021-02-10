using System;
using System.Collections.Generic;
using objectCompare.Entities;

namespace objectCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            //Client b = new Client { Name = "Maria", Email = "maria@gmail.com" };

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a == b);
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            HashSet<Product> x = new HashSet<Product>();
            x.Add(new Product("TV", 900.0));
            x.Add(new Product("Notebook", 1200.0));

            HashSet<Point> y = new HashSet<Point>();
            y.Add(new Point(3, 4));
            y.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(x.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(y.Contains(p));
        }
    }
}
