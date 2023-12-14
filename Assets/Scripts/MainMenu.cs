using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToChapOne()
    {
        SceneManager.LoadScene(1); 
    }

    public void QuitGame()
    {
        Debug.Log("Game Quit"); 
        Application.Quit(); 
    }

    public void Restart()
    {
        SceneManager.LoadScene(0); 
    }
}
