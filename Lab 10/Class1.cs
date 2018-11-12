using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Circle
    {
        private double _radius;
        

        


        public Circle(double radius)
        {
            _radius = radius;
           
        }
        
        

        public double CaluculateCircumference()
        {
            double pi = Math.PI;
            double circumference = 2 * pi * _radius;
            return circumference;


        }
        public string CalculateFormattedCircumference()
        {
            double circumference = CaluculateCircumference();
            string formattedCircumference = FormatNumber(circumference);
            return formattedCircumference;

        }

        public double CalculateArea()
        {
            double pi = Math.PI;
            double area = pi * (_radius * _radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            double Calculatesrea = CalculateArea();
            string formatArea = FormatNumber(CalculateArea());
            return formatArea;

        }

        private string FormatNumber(double x)

        {
            x = Math.Floor(x * 100) / 100 ;
            return x.ToString();
        }
        
    }
}
