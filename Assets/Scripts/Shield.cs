using UnityEngine;
using AG3954;

public class Shield : MonoBehaviour, IWeaponSystem
{
    public int damage = 0;

    public int Damage()
    {
        return damage;
    }

    public void Equip(Transform enemy)
    {
        transform.SetParent(enemy);
        transform.localPosition = new Vector3(-0.534f, 0.225f, 0.397f);
        transform.localRotation = Quaternion.Euler(0f, 58f, 90f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Equip(other.transform);
            Debug.Log("Shield triggered and equipped!");
        }
    }
}
