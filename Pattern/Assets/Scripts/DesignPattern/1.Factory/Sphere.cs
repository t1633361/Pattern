using UnityEngine;

namespace DesignPattern.Factory
{
    public class Sphere : IShape
    {
        public void Draw()
        {
            Debug.Log("Sphere");
        }
    }
}
