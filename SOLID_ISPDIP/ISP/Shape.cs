using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISPDIP.ISP
{
    internal interface IArea
    {
        double GetArea();
    }

    internal interface IDrawable
    {
        double Draw();
    }

    internal interface IShape: IArea, IDrawable
    {

    }

    internal class Circle : IShape
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

        double IDrawable.Draw()
        {
            throw new NotImplementedException();
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

        double IDrawable.Draw()
        {
            throw new NotImplementedException();
        }
    }



}
