using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Line
    {
        private Point start;
        private Point end;

        public Point Start
        {
            get { return start; }
            set { start = value; }
        }

        public Point End
        {
            get { return end; }
            set { end = value; }
        }

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public override string ToString()
        {
            return $"Линия от {Start} до {End}";
        }
    }
}