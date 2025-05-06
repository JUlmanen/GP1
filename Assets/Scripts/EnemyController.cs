using UnityEngine;

namespace AG3954
{
    public class EnemyController : MonoBehaviour
    {
        public float moveSpeed = 2f;
        protected Vector3 moveDirection;

        //This is needed for initializing base in EnemyPatrol
        protected virtual void Start()
        {

        }

        protected virtual void Move()
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        protected virtual void Update()
        {
            Move();
        }
    }
}