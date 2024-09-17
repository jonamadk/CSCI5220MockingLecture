using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISPDIP.ISPViolation
{
    internal interface IShape
    {
        double GetArea();
        void Draw();


    }

    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the Circle");
        }

        public double GetArea()
        {
            Console.WriteLine("Drawing the Circle Area");
            return 0;
        }
    }


    internal class Reactangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the Reactangle");
        }

        public double GetArea()
        {
            Console.WriteLine("Drawing the Reactangle Area");
            return 0;
        }
    }

}
