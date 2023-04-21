using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary
{
    public class IShapeResponse
    {
        public static double Calculate(IShape shape)
        {
            return shape.CalculateArea();
        }
        public static bool IsRight(IShape shape)
        {
            return shape.IsRightTriangle();
        }
    }
}
