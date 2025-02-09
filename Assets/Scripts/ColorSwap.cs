using JetBrains.Annotations;
using Unity.FPS.Game;
using UnityEngine;

namespace AG3954
{
    public class ColorSwap : Damageable
    {
        public Renderer objectRenderer;
        public Color swapColor = Color.green;
        public Color originalColor;
        public bool colorSwapped = false;
        
        void Start()
        {
            objectRenderer = GetComponent<Renderer>();
            originalColor = objectRenderer.material.color;
        }

        public override void InflictDamage(float damage, bool isExplosionDamage, GameObject damagesource)
        {
            base.InflictDamage(damage, isExplosionDamage, damagesource);

            SwapColor();
        }

        public void SwapColor() 
        {
            if (!colorSwapped)
            {

            }
        }
        
        void Update()
        {

        }
    } 
}
