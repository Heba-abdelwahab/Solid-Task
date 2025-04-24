using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1
{
    public interface IArea
    {
        Double GetArea();

    }
    public interface IVolume
    {
        Double GetVolume();

    }

    public class Rectangle :IArea
    {
        public double Height { get; set; }
        public double Wight { get; set; }

        public double GetArea()
        {
            return Height * Wight;
        }
    }
    public class Circle:IArea
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return 3.14159*Radius*Radius;
        }
    }
    public class Square:IArea
    {
        public int lengthL { get; set; }
        public double GetArea()
        {
            return lengthL * lengthL;
        }
    }
    public class Triangle:IArea
    {
        public int lengthL1 { get; set; }
        public int lengthL2 { get; set; }
        public int lengthL3 { get; set; }

        public double GetArea()
        {
             double s = (lengthL1 + lengthL2 + lengthL3) / 2;
            return Math.Sqrt(s * (s - lengthL1) * (s - lengthL2) * (s - lengthL3));
        }
    }
    public class Cube:IArea, IVolume
    {
        public int lengthL { get; set; }

        public double GetArea()
        {
            return 6 * Math.Pow(lengthL, 2);
    
        }

        public double GetVolume()
        {
            return Math.Pow(lengthL, 3);
        }
    }
    //public class AreaCalculator
    //{
    //    public double TotalArea(object[] arrObjects)
    //    {
    //        double area = 0;
    //        Rectangle objRectangle;
    //        Circle objCircle;
    //        foreach (var obj in arrObjects)
    //        {
    //            if (obj is Rectangle)
    //            {
    //                area += obj.Height * obj.Width;
    //            }
    //            else
    //            {
    //                objCircle = (Circle)obj;
    //                area += objCircle.Radius * objCircle.Radius * Math.PI;
    //            }
    //        }
    //        return area;
    //    }
    //}
    public class AreaCalculator
    {
        public double TotalArea(IArea[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects)
            {
                area += obj.GetArea();
            }
            return area;
        }
    }
    internal class Task2
    {
    }
}
