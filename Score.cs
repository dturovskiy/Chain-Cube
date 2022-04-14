using ChainCube.Scripts.Cube;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PointsContainerCollisionDetector), typeof(PointsContainer))]
public class Score : MonoBehaviour
{
    public Text score;

    private void Update()
    {
        score.text = $"{CollisionMergePointsContainer.score}";
    }
}
