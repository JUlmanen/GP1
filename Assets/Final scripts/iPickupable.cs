using UnityEngine;

namespace AG3954
{
    //POLYMORPHISM, INTERFACE
    public interface IPickupable // Interface for pickupable objects, in this project just the spears. Could be used for multiple different objects.
    {
        void OnPickup(Transform handTransform);  // Called when spear is picked up
        void Throw(Vector3 direction, float force);  // Called when spear is thrown
    }
}