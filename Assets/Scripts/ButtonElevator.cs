using System;
using UnityEngine;
namespace AG3954
{
    public class ButtonElevator : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed = 2f;
        public Transform topPosition;
        public Transform bottomPosition;
        private bool movingUp = false;
        private bool isMoving = false;

        public delegate void ElevatorMoveEventHandler();
        public event ElevatorMoveEventHandler OnElevatorMove;

        //Encapsulated moveSpeed data
        public float MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        void Update()
        {
            // Move the elevator only if it's supposed to be moving, also writes a console log about it for testing
            if (isMoving)
            {
                MoveElevator();
                Debug.Log("Elevator is moving");
            }
        }

        // This starts moving the ButtonElevator
        public void StartMovingElevator()
        {
            OnElevatorMove?.Invoke();
            isMoving = true;
        }

        private void MoveElevator()
        {
            // This determines the target position of the ButtonElevator
            Transform targetPosition = movingUp ? topPosition : bottomPosition;

            // This moves the elevator towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);

            // This checks if the elevator has reached the target position
            if (transform.position == targetPosition.position)
            {
                movingUp = !movingUp;
                isMoving = false;
            }
        }
    }
}