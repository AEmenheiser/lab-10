using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validator : Circle 
    {
        public Validator(double radius) : base(radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("try again");
            }

        }

        

    }
}

