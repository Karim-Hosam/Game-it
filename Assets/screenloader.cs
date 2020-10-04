using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenloader : MonoBehaviour
{
 public void LoadGame()
    {
        SceneManager.LoadScene("Sandbox");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
