using System;

namespace Triangle
{
    using System;
    public class Exercise14
    {
        public static void Main()
        {
            int SideX, SideY, SideZ;
            Console.Write("\n\n");
            Console.Write("Check If the triangle is Equilateral, Isosceles or Scalene:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Enter side A of triangle: ");
            SideX  = int.Parse(Console.ReadLine());

            Console.Write("Enter side B of triangle: ");
            SideY = int.Parse (Console.ReadLine());

            Console.Write("Enter side C of triangle: ");
            SideZ = int.Parse (Console.ReadLine());



            if (SideX == SideY && SideY == SideZ)
            {
                Console.Write("This is an Equilateral triangle.\n");
            }
            else if (SideX == SideY || SideX == SideZ  || SideY == SideZ)
            {
                Console.Write("This is an Isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a Scalene triangle.\n");
            }
        }
    }

}
