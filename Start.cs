using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    //public Button startButton;
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
