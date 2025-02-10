using UnityEngine;

namespace AG3954
{
    public class MyScript : MonoBehaviour
    {
        public class AnObject
        {
            public string name;
            public bool booleanTest;
            public int value;

            public AnObject(string name, bool booleanTest, int value)
            {
                this.name = name;
                this.booleanTest = booleanTest;
                this.value = value;
            }
        }

        void Start()
        {
            AnObject obj = new AnObject("Test Object", true, 15);

            Debug.Log("This object spawned: " + obj.name + ", boolean set as: " + obj.booleanTest + ", and value: " + obj.value);
        }
    }
}
