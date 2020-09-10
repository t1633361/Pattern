using System;

namespace DesignPattern.Factory
{
    public static class ShapeFactory
    {
        public static IShape GetShape(string type)
        {
            if(type.Equals("Cube"))
                return new Cube();
            else if(type.Equals("Sphere"))
                return new Sphere();
            else
                throw new NotImplementedException();
        }
    }
}
