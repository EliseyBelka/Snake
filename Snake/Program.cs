using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 4,'#');
            p2.Draw();

            Point p3 = new Point(3, 1, '%');
            p3.Draw();

            Point p4 = new Point(5, 2, '&');
            p4.Draw();

            List<Point> pos = new List<Point>();
                pos.Add(p1);
                pos.Add(p2);
                pos.Add(p3);
                pos.Add(p4);

            foreach (var item in pos)
            {
                Console.WriteLine(item.sym);
            }

            Console.ReadLine();
        }
    }
}
