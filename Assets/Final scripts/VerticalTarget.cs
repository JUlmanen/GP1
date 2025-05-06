using UnityEngine;

namespace AG3954
{
    //INHERITANCE
    public class VerticalTarget : RotatingObject //Inherits from RotatingObject to get the call for rotating, but the direction of movement is set here
    {
        protected override Vector3 GetRotationAxis()
        {
            return Vector3.right;           // Rotate target around X-axis (vertical)
        }

        //POLYMORPHISM
        public override int GetScoreValue()
        {
            return 2;                       // Add 2 points for hitting this target
        }
    }
}
