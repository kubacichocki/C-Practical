using System;

namespace ConsoleApp1
{

    class Cylinder
    {
        private double height;
        private double radius;

        public Cylinder(double r, double h)
        {
            height = h;
            radius = r;
        }

        public double VolumeCalculation()
        {
            return 3.142 * radius * radius * height;
        }

        public double getHeight()
        {
            return (height);
        }

        public double getRadius()
        {
            return (radius);
        }

    }


    class TestingClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylinder");
            Cylinder c = new Cylinder(2, 3);  
            Console.WriteLine(c.VolumeCalculation());

        }
    }
}
