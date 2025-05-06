using UnityEngine;
using AG3954;

public class Vertical : MonoBehaviour, IRotateInheritance
{
    public float spinSpeed = 30f;

    void Update()
    {
        HorizontalSpin();
        VerticalSpin();
    }

    public void HorizontalSpin()
    {

    }

    public void VerticalSpin()
    {

        transform.Rotate(spinSpeed * Time.deltaTime, 0, 0);        
    }

}