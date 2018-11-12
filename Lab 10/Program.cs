using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets make a shape!");
            int repeatnumber = 0;

            do
            {
                Console.WriteLine("please enter 'square' or 'circle'");// just wanted to see if I could putz around a bit
                string question = Console.ReadLine();
                question.ToLower();
                if (question == "square")
                {
                    Console.WriteLine("please enter a single side of this 'square'");
                    double.TryParse(Console.ReadLine(), out double side1);
                    Square x = new Square(side1);
                    Console.WriteLine("the perimeter is {0}", x.Perimiter());
                    Console.WriteLine("the area of your square is {0}", x.CalculateAreasq());
                }
                else if (question == "circle") 
                {

                    Console.WriteLine("Please enter a Radius for your circle");

                    double.TryParse(Console.ReadLine(), out double radius);
                    Circle y = new Circle(radius);

                    Console.WriteLine("the area is {0}", y.CalculateFormattedArea());
                    Console.WriteLine("the circumference is {0}", y.CalculateFormattedCircumference());

                }
               
                repeatnumber++;
                Console.WriteLine("Would you Like to continue? y/n");
            } while (Console.ReadLine() == "y"); Console.WriteLine($"See you later! Today, you have made {repeatnumber} shape objects");
            Console.ReadKey();

           
        }
    }




}

