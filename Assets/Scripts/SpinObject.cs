using UnityEngine;
namespace AG3954

{
    public class SpinObject : MonoBehaviour
    {
        public float spinSpeed = 30f; 

        void Update()
        {
            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }
    }
}
