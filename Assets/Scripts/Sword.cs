using UnityEngine;
using AG3954;

public class Sword : MonoBehaviour, IWeaponSystem
{
    public int damage = 25;

    public int Damage()
    {
        return damage;
    }

    public void Equip(Transform enemy)
    {
        transform.SetParent(enemy);

        transform.localPosition = new Vector3(0.495f, 0.225f, 0.366f);
        transform.localRotation = Quaternion.Euler(34f, 0f,0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Equip(other.transform);
            Debug.Log("Sword triggered and equipped!");
        }
    }
}
