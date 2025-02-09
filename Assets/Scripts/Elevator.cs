using JetBrains.Annotations;
using UnityEngine;

namespace ag3954
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;

        public float speed = 1.0f;
        private Transform target;
        private int currentEndPointIndex = 0;


        void Start()
        {
            target = targetEndPoints[0];
        }

        // Update is called once per frame
        void Update()
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                SwapEndPointTarget();
            }
        }
        void SwapEndPointTarget()
        {
            currentEndPointIndex++;
            currentEndPointIndex %= targetEndPoints.Length;
            target = targetEndPoints[currentEndPointIndex];
        }
    }
}
