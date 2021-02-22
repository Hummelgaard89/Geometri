using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private int a;
        private int perimeter;
        private int area;

        public Square()
        {
            a = 4;
        }
        public void Calculate_Square_Perimeter() //Metode til udregning af omkreds
        {
            perimeter = a * 4;
        }
        public void Calculate_Square_Area() //Metode til udregning af areal
        {
            area = a * 2;
        }
        public int SideA //get/set af side a.
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public void Print_Square() //Metode til at udskrive firkant
        {
            Console.WriteLine("Side a is = " + a);
            Console.WriteLine("Perimeter of the square is = " + perimeter);
            Console.WriteLine("Area of the square is = " + area);
        }
    }
}
