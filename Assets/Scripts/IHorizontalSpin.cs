using AG3954;
using UnityEngine;

    public class Horizontal : MonoBehaviour, IRotateInheritance
    {
        public float spinSpeed = 30f;

        void Update()
        {
            HorizontalSpin();
            VerticalSpin();
        }

        public void HorizontalSpin()
        {
            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }

        public void VerticalSpin()
        {
            
        }
    }


