using UnityEngine;

public class MouseSettings : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
    }
}
