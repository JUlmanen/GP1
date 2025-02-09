using UnityEngine;
namespace AG3954
{
    public class ChangeObjectColor : MonoBehaviour
    {
        private Renderer objRenderer;
        private Color originalColor;

        public Color touchColor = Color.blue; 
        public string playerTag = "Player";

        private void Start()
        {
            objRenderer = GetComponent<Renderer>();

            originalColor = objRenderer.material.color;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(playerTag))
            {
                ChangeColor(touchColor);
            }
        }

        private void ChangeColor(Color newColor)
        {
            if (objRenderer.material.HasProperty("_BaseColor"))
            {
                objRenderer.material.SetColor("_BaseColor", newColor);
            }
            else
            {
                objRenderer.material.color = newColor;
            }
        }
    }
}