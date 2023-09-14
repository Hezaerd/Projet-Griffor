using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCanva : MonoBehaviour
{
    // public MusicManager mMusicManager

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}