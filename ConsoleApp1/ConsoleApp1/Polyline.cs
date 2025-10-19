using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Polyline
    {
        public List<Point> Points { get; set; }

        public Polyline(List<Point> points)
        {
            Points = points;
        }

        public override string ToString()
        {
            return $"Линия [{string.Join(", ", Points)}]";
        }
    }
}
