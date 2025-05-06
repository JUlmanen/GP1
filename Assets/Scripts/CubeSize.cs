using UnityEngine;
using UnityEngine.UIElements;
namespace AG3954
{
    public abstract class CubeSize : MonoBehaviour
    {
        public float height;
        public float width;
        public float length;

        public abstract void ChangeSize();
    }
}