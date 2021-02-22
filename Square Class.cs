using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Her Opretter jeg første firkant
            Square FirkantA = new Square();
            FirkantA.Calculate_Square_Perimeter();
            FirkantA.Calculate_Square_Area();
            FirkantA.Print_Square();
            Console.WriteLine();
            ///////////////////////////////////////
            //Her opretter jeg anden firkant og ændre værdien med get/set
            Square FirkantB = new Square();
            FirkantB.SideA = 6;
            FirkantB.Calculate_Square_Perimeter();
            FirkantB.Calculate_Square_Area();
            FirkantB.Print_Square();
            Console.WriteLine();
            ///////////////////////////////////////
            //Her opretter jeg 3 firkant og ændre værdien med get/set
            Square FirkantC = new Square();
            FirkantC.SideA = 8;
            FirkantC.Calculate_Square_Perimeter();
            FirkantC.Calculate_Square_Area();
            FirkantC.Print_Square();
            Console.ReadLine();
        }
    }
}
