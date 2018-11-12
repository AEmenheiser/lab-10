using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Square
    {
        private double _side1;
    

        public Square(double side1)
        {
            _side1 = side1;

        }
        public double CalculateAreasq()
        {
            double sq = _side1 * _side1;
            return sq;
        }
        public double Perimiter()
        {
            double perimiter = _side1 + _side1 + _side1 + _side1;
            return perimiter;
        }
    }

    }

