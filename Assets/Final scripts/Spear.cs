using AG3954;
using UnityEngine;
using System.Collections;

namespace AG3954
{
    //INTERFACE
    public class Spear : MonoBehaviour, IPickupable // Handles the spear’s behavior, like attaching to hand, disabling physics, or enabling pickup again.
    {
        //ENCAPSULATION
        private Rigidbody rb;                      // Declares a variable which's type is Rigidbody names rb 
        //ENCAPSULATION
        private bool canBePickedUp = true;         // Check for if spear can be picked up 
        //ENCAPSULATION
        private Collider spearCollider;            // Used for enabling/disabling collisions, so the spear doesn't get stuck in player 

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();        // Get rigidbody of the soear
            spearCollider = GetComponent<Collider>();  // Get collider of the spear

            if (rb == null) rb = gameObject.AddComponent<Rigidbody>();  // Ensures spear's rigidbody exists
            rb.isKinematic = true;                 // Prevent movement of the spear until thrown
        }

        private void OnTriggerEnter(Collider other) // Automatically picks up the spear when player touches it
        {
            if (canBePickedUp && other.CompareTag("Player"))    // Checks if player can pick up a spear (no spear in hand) and the object touching the spear is tagged as player
            {
                var player = other.GetComponent<PlayerController>();    //
                if (player != null)
                {
                    player.PickupSpear(this);       // Assign spear to player
                    canBePickedUp = false;
                }
            }
        }

        public void OnPickup(Transform handTransform) 
        {
            
            transform.SetParent(handTransform); // Attach spear to player's hand
            transform.localPosition = Vector3.zero; //Reset spear's position
            transform.localRotation = Quaternion.identity; //Reset spear's rotation

            rb.isKinematic = true;                // Disable physics while held
            spearCollider.enabled = false;        // Prevent accidental collisions
        }

        public void Throw(Vector3 direction, float force) //ENCAPSULATION (from IPickupable interface)
        {
            transform.SetParent(null);            // Detach spear from hand

            rb.isKinematic = false;               // Enable physics of the spear
            spearCollider.enabled = true;

            rb.linearVelocity = Vector3.zero;     // Clear old motion, so the spear goes where it is aimed at
            rb.angularVelocity = Vector3.zero;
            rb.AddForce(direction * force, ForceMode.Impulse);  // Apply throw direction and force, impulse applies force instantly to the spear for better throwing experience :)
        }

        private void OnCollisionEnter(Collision collision) // This applies score when the spear hits the target.
        {
            RotatingObject target = collision.collider.GetComponent<RotatingObject>();
            if (target != null)
            {
                int points = target.GetScoreValue();           // Get points from hitting a target with spear
                GameManager.Instance.AddScore(points);         // Add to global score (that is used in the player's HUD). "Instance" is used for access 
                                                               //of the singleton instance of the GameManager
            }
        }
    }
}