using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonmanager : MonoBehaviour
{
    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
