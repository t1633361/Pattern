using UnityEngine;

namespace DesignPattern.Factory
{
    public class FactorySample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var cube   = ShapeFactory.GetShape("Cube");
            var sphere = ShapeFactory.GetShape("Sphere");
            cube.Draw();
            sphere.Draw();
        }
    }
}
