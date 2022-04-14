using ChainCube.Scripts.Cube;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Close : MonoBehaviour
{
    public void ExitToMenu()
    {
        SceneManager.LoadScene("StartScene");

        CollisionMergePointsContainer.score = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
