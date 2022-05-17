using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TLine2D line1 = new TLine2D(1, 2, 3, 4);
            TLine2D line2 = new TLine2D(2, 4, 6, 8);
            if (line1.IsParallel(line1, line2) == true)
                Console.WriteLine("Ваші прямі паралельні");
            else
                Console.WriteLine("Ваші прямі не паралельні");
            if (line1.IsPerpendicular(line1, line2) == true)
                Console.WriteLine("Ваші прямі перпендикулярні");
            else
                Console.WriteLine("Ваші прямі не перпендикулярні");
            TLine3D line3 = new TLine3D(1, 2, 3, 4, 5, 6);
            TLine3D line4 = new TLine3D(2, 4, 6, 8, 10, 12);
            if (line3.IsPerpendicular(line3, line4) == true)
                Console.WriteLine("Ваші прямі перпендикулярні");
            else
                Console.WriteLine("Ваші прямі не перпендикулярні");
        }
    }
    class TLine2D
    {
        protected double x1;
        public double X1 { get { return x1; } set { x1 = value; } }
        protected double x2;
        public double Y1 { get { return y1; } set { y1 = value; } }
        protected double y2;
        public double X2 { get { return x1; } set { x2 = value; } }
        protected double y1;
        public double Y2 { get { return y2; } set { y2 = value; } }
        public TLine2D()
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
        }
        public TLine2D(double xy)
        {
            X1 = xy;
            Y1 = xy;
            X2 = xy;
            Y2 = xy;
        }
        public TLine2D(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = x2;
            X2 = y1;
            Y2 = y2;
        }
        public bool IsParallel(TLine2D line1, TLine2D line2)
        {
            double k1 = (line1.x2 - line1.x1) / (line1.y2 - line1.y1);
            double k2 = (line2.x2 - line2.x1) / (line2.y2 - line2.y1);
            if(k1 == k2)
                return true;
            else
                return false;
        }
        public bool IsPerpendicular(TLine2D line1, TLine2D line2)
        {
            double scalar = ((line1.x2 - line1.x1) * (line2.x2 - line2.x1)) + ((line1.y2 - line1.y1) * (line2.y2 - line2.y1));
            if (scalar == 0)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return $"Координати точок прямої: ({x1};{y1}) ({x2};{y2})";
        }
    }
    class TLine3D : TLine2D
    {
        protected double z1;
        public double Z1 { get { return z1; } set { z1 = value; } }
        protected double z2;
        public double Z2 { get { return z2; } set { z2 = value; } }
        public TLine3D() : base()
        {
            Z1 = 0;
            Z2 = 0;
        }
        public TLine3D(double x) : base(x)
        {
            Z1 = x;
            Z2 = x;
        }
        public TLine3D(double x1, double x2, double y1, double y2, double z1, double z2) : base(x1, x2, y1, y2)
        {
            Z1 = z1;
            Z2 = z2;
        }
        public bool IsPerpendicular(TLine3D line3, TLine3D line4)
        {
            double scalar = ((line3.x2 - line3.x1) * (line4.x2 - line4.x1)) + ((line3.y2 - line3.y1) * (line4.y2 - line4.y1)) + ((line3.z2 - line3.z1) * (line4.z2 - line4.z1));
            if (scalar == 0)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return $"Координати початку та кінця відрізка: ({x1};{y1};{z1}) ({x2};{y2};{z2})";
        }
    }
}
