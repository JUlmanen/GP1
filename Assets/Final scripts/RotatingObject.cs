using UnityEngine;

namespace AG3954
{
    //ABSTRACT CLASS
    public abstract class RotatingObject : MonoBehaviour
    {
        [SerializeField] protected float rotationSpeed = 30f;  // Sets the speed of rotation

        //ABSTRACT METHOD
        protected abstract Vector3 GetRotationAxis();          // Sets axis to rotate around (from subclass)

        //VIRTUAL METHOD
        public virtual void Rotate()
        {
            transform.Rotate(GetRotationAxis() * rotationSpeed * Time.deltaTime);
        }

        //ABSTRACT METHOD & POLYMORPHISM
        public abstract int GetScoreValue();                   // Return score value when spear hits a target
    }
}
