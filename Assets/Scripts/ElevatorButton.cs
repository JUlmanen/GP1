using UnityEngine;

namespace AG3954
{
    public class ElevatorButton : MonoBehaviour
    {
        public ButtonElevator elevator; // Reference to the elevator

        // When the player steps on the button
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                // Trigger the elevator to start moving
                Debug.Log("Player stepped on the button.");
                elevator.StartMovingElevator();
            }
        }
    }
}