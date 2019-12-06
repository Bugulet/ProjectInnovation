using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

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

    public void StartArtist()
    {
        SceneManager.LoadScene(5);
    }

    public void StartEngineer()
    {
        SceneManager.LoadScene(6);
    }

    public void StartDesigner()
    {
        SceneManager.LoadScene(7);
    }
}
