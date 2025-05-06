using UnityEngine;
namespace AG3954
{
    public interface IWeaponSystem
    {
        void Equip(Transform enemy);

        int Damage();
    }
}

