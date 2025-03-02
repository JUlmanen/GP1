using UnityEngine;

namespace AG3954
{
    public class FindScript : MonoBehaviour
    {
        public GameObject buttonElevator;
        public GameObject player;

        [SerializeField]
        private ButtonElevator elevator;

        void FindObject()
        {
            buttonElevator = GameObject.Find("ButtoneElevator");

            player = GameObject.FindWithTag("Player");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                elevator.enabled = true;
                Debug.Log("Player has stepped on the elevator button");
            }
        }
    }
}
