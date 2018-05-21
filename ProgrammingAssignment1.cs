using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Program Assignment "It's All Greek to Me!"
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Assignment "It's All Greek to Me!"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome! This application will calculate the distance between two points and the angle between those points.");
            Console.WriteLine();

            // prompt and get x and y values of the two points
            Console.WriteLine("Please, insert X value for the first point:");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert Y value for the first point:");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert X value for the second point:");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert Y value for the second point:");
            float point2Y = float.Parse(Console.ReadLine()); 

            // calculate deltas
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // print delta values to console
            Console.WriteLine("Delta X: " + deltaX);
            Console.WriteLine("Delta Y: " + deltaY);

            // calculate distance between X and Y
            double distance = Math.Sqrt(Math.Pow(deltaX,2)+ Math.Pow(deltaY, 2));

            // calculate angle between X and Y
            double angle = Math.Atan2(deltaY, deltaX);

            // convert from radians to degrees
            double degAngle = 180*angle/Math.PI;

            // print distance value and angle to console
            Console.WriteLine("Distance between X and Y: {0:N3}.", distance);
            Console.WriteLine("Angle between X and Y: {0:N3}.", degAngle);

            Console.WriteLine();
        }
    }
}
