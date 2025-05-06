using UnityEngine;

namespace AG3954
{
    public class EnemyPatrol : EnemyController
    {
        public Transform pointA;
        public Transform pointB;
        public float minDistanceToTarget = 1f;

        private Transform currentTarget;

        protected override void Start()
        {
            base.Start();

            currentTarget = pointB;
            SetDirection();
        }

        protected override void Move()
        {
            base.Move();

            if (Vector3.Distance(transform.position, currentTarget.position) <= minDistanceToTarget)
            {
                SwitchTarget();
                SetDirection();
            }
        }

        private void SwitchTarget()
        {
            currentTarget = currentTarget == pointA ? pointB : pointA;
        }

        private void SetDirection()
        {
            if (currentTarget != null)
            {
                moveDirection = (currentTarget.position - transform.position).normalized;
            }
        }
    }
}