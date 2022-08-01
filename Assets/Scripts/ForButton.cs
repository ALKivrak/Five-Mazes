using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForButton : MonoBehaviour
{
    [SerializeField]
    private string firstLevel = "1";

    public void playGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void exit()
    {
        Application.Quit();
    }
}
