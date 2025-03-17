using Unity.FPS.Game;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] int hp;

    public abstract void Heal();
    public abstract void Damage();


}
