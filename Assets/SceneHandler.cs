using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    public void StartPoster()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void StartNavigation()
    {
        SceneManager.LoadScene(3);
    }

    public void StartWorkflow()
    {
        SceneManager.LoadScene(4);
    }
}
