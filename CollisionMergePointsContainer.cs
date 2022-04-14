using UnityEngine;

namespace ChainCube.Scripts.Cube
{
    [RequireComponent(typeof(PointsContainerCollisionDetector), typeof(PointsContainer))]
    public class CollisionMergePointsContainer : MonoBehaviour
    {
        public static long score;

        private PointsContainer _pointsContainer;
        private PointsContainerCollisionDetector _detector;

        private void Start()
        {
            _pointsContainer = GetComponent<PointsContainer>();
            _detector = GetComponent<PointsContainerCollisionDetector>();
            Subscribe();
        }

        private void OnPointsContainerCollision(PointsContainer col)
        {
            if (col.points == _pointsContainer.points)
            {
                _pointsContainer.points *= 2;
                Destroy(col.gameObject);
                score += _pointsContainer.points;
            }
        }

        private void Subscribe()
        {
            _detector.onCollisionContinue += OnPointsContainerCollision;
        }

        private void Unsubscribe()
        {
            _detector.onCollisionContinue -= OnPointsContainerCollision;
        }

        private void OnDestroy()
        {
            Unsubscribe();
        }
    }
}
