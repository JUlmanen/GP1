using AG3954;
using UnityEngine;
namespace AG3954
{
    public class CubeBig : CubeSize
    {
        private void Start()
        {
            ChangeSize();
        }

        public override void ChangeSize()
        {
            height = 3;
            width = 4;
            length = 5;
            transform.localScale = new Vector3(width, height, length);
            Debug.Log("Box is now big");
        }
    }
}

