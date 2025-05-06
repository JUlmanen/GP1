using UnityEngine;

namespace AG3954
{
    //INHERITANCE
    public class HorizontalTarget : RotatingObject //Inherits from RotatingObject to get the call for rotating, but the direction of movement is set here
    {
        protected override Vector3 GetRotationAxis()
        {
            return Vector3.up;              // Rotate target around Y-axis (horizontal)
        }

        //POLYMORPHISM
        public override int GetScoreValue()
        {
            return 1;                       // Add 1 point for hitting this target
        }
    }
}
