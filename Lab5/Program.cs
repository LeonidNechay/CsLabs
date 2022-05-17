using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TInterval2D interval1 = new TInterval2D(1, 2, 3, 4);
            TInterval2D interval2 = new TInterval2D(4, 3, 2, 1);
            interval1.GetLength();
            interval1.GetMiddle();
            Console.WriteLine(interval1 + interval2);
            Console.WriteLine(interval1);
            TInterval3D interval3 = new TInterval3D(1, 2, 3, 4, 5, 6);
            TInterval3D interval4 = new TInterval3D(6, 5, 4, 3, 2, 1);
            Console.WriteLine(interval3 + interval4);
            Console.WriteLine(interval3);
            TInterval2D interval5 = new TInterval2D();
            Console.WriteLine(interval5);
            TInterval2D interval6 = new TInterval2D(3);
            Console.WriteLine(interval6);
            Console.ReadLine();
        }
    }
    class TInterval2D
    {
        protected double x1;
        public double X1 { get { return x1; } set { x1 = value; } }
        protected double x2;
        public double Y1 { get { return y1; } set { y1 = value; } }
        protected double y2;
        public double X2 { get { return x1; } set { x2 = value; } }
        protected double y1;
        public double Y2 { get { return y2; } set { y2 = value; } }
        public TInterval2D()
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
        }
        public TInterval2D(double xy)
        {
            X1 = xy;
            Y1 = xy;
            X2 = xy;
            Y2 = xy;
        }
        public TInterval2D(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = x2;
            X2 = y1;
            Y2 = y2;
        }

        public void GetLength()
        {
            Console.WriteLine($"Довжина відрізка: {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
        }
        public (double x, double y) GetMiddle(double length)
        {
            var x = (x1 + x2) / length;
            var y = (y1 + y2) / length;
            return (x, y);
        }
        public static TInterval2D operator +(TInterval2D interval1, TInterval2D interval2)
        {
            return new TInterval2D(interval1.x1, interval1.y1, interval2.x2, interval2.y2);
        }
        public static TInterval2D operator *(TInterval2D interval1, TInterval2D interval2)
        {
            return new TInterval2D(interval1.x1 * interval2.x1, interval1.y1 * interval2.y1, interval1.x2 * interval2.x2, interval1.y2 * interval2.y2);
        }
        public override string ToString()
        {
            return $"Координати початку та кінця відрізка: ({x1};{y1}) ({x2};{y2})";
        }
    }
    class TInterval3D : TInterval2D
    {
        protected double z1;
        public double Z1 { get { return z1; } set { z1 = value; } }
        protected double z2;
        public double Z2 { get { return z2; } set { z2 = value; } }
        public TInterval3D() : base()
        {
            Z1 = 0;
            Z2 = 0;
        }
        public TInterval3D(double x) : base(x)
        {
            Z1 = x;
            Z2 = x;
        }
        public TInterval3D(double x1, double x2, double y1, double y2, double z1, double z2) : base(x1, x2, y1, y2)
        {
            Z1 = z1;
            Z2 = z2;
        }
        public new void GetLength()
        {
            Console.WriteLine($"Довжина відрізка: {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
        }
        public new (double x, double y, double z) GetMiddle(double length)
        {
            double x = (x1 + x2) / length;
            double y = (y1 + y2) / length;
            double z = (z1 + z2) / length;
            return (x, y, z);
        }
        public static TInterval3D operator +(TInterval3D interval3, TInterval3D interval4)
        {
            return new TInterval3D(interval3.x1, interval3.y1, interval3.z1, interval4.x2, interval4.y2, interval4.z2);
        }
        public static TInterval3D operator *(TInterval3D interval3, TInterval3D interval4)
        {
            return new TInterval3D(interval3.x1 * interval4.x1, interval3.y1 * interval4.y1, interval3.z1 * interval4.z1, interval3.x2 * interval4.x2, interval3.y2 * interval4.y2, interval3.z2 * interval4.z2);
        }
        public override string ToString()
        {
            return $"Координати початку та кінця відрізка: ({x1};{y1};{z1}) ({x2};{y2};{z2})";
        }
    }
}