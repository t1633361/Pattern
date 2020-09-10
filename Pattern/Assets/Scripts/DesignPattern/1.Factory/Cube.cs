using UnityEngine;

namespace DesignPattern.Factory
{
    public class Cube : IShape
    {
        public void Draw()
        {
            Debug.Log("Cube");
        }
    }
}
