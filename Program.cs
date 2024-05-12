using System;

namespace SphereRings
{
    // C# program to calculate the diameters
    // of each ring in a wooden sphere. The
    // diameter of the sphere is 497mm and
    // the thickness of the wood is 17mm.
    // Apart from the middle widest ring,
    // each additional ring is inset into
    // its neighbour by 2mm, so the rings
    // step up in 15mm thick steps.

    class Program
    {
        static void Main()
        {
            // This works out the ring diameter
            // for each nth ring, where n is 0
            // for the middle ring, and 1 to 15
            // for each of the other rings.

            for(var n = 0; n <= 16; n = n+1)
            {
                var r = 497.0 / 2;
                var y = 8.5 + 15 * n;

                // Use Pythagoras to calculate
                // the diameter of each ring.

                var d = 2 * Math.Sqrt(Sqr(r) - Sqr(y));
                Console.WriteLine($"Ring {n} = {d:N2}mm");
            }
        }
        static double Sqr(double v) => v * v;
    }
}
