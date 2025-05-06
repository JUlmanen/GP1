using UnityEngine;

namespace AG3954
{
    public class RotationController : MonoBehaviour
    {
        private RotatingObject[] rotatingObjects; // Reference to rotating objects

        private void Start()
        {
            //FINDING OBJECT BY TYPE
            rotatingObjects = FindObjectsOfType<RotatingObject>();  // Find all targets by their type "RotatingObject" 
        }

        private void Update()
        {
            foreach (RotatingObject obj in rotatingObjects)
            {
                obj.Rotate();                                       // Call their Rotate() every frame
            }
        }
    }

}
