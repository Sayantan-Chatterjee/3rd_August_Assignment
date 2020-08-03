using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    interface IVolume
    {
        double Volume();
    }
    interface IArea
    {
        double SurfaceArea();
    }
    interface ISolid : IVolume,IArea
    {

    }

    abstract class Solid
    {
        public double radious;
        public const p = 3.142;
    } 

    class InterfaceAssign
    {
        public void Main()
        {

        }
    }
}
