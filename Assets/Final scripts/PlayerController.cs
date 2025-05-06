using AG3954;
using UnityEngine;

public class PlayerController : MonoBehaviour //This script controls player input and behavior: detecting mouse button presses and triggering actions
{
    [SerializeField] private float throwForce = 20f;       // Force applied to throw
    [SerializeField] private Transform handTransform;      // Where the spear is held

    private Spear currentSpear;                            // Reference to held spear ENCAPSULATION
    private Camera mainCamera;                             // Reference to main camera, with which the spear will move ENCAPSULATION

    private void Awake()
    {
        //FINDING OBJECT
        mainCamera = Camera.main;                          // Get the main camera 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentSpear != null) // Throw spear with left click (Mouse 0) and spear is in hand
        {
            ThrowSpear();                                       // Calls for the ThrowSpear method, where the actual throwing happens
        }
    }

    public void PickupSpear(Spear spear)            
    {
        if (currentSpear != null) return;                  // Only one spear can be in hand at a time
        currentSpear = spear;
        currentSpear.OnPickup(handTransform);              // Attaches spear to hand object
    }

    private void ThrowSpear()
    {
        Vector3 throwDirection = mainCamera.transform.forward;  // Sets throw direction of the spear to forward from main camera
        currentSpear.Throw(throwDirection, throwForce);         // Throw spear forward when it's held and left mouse button is pressed
        currentSpear = null;                                    // Sets currentSpear to null, so new spear can be picked up
    }
}