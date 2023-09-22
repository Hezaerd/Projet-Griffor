using UnityEngine;
using UnityEditor.SceneManagement;

namespace ProjectGriffor
{
    public class MainMenuCanva : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneLoader.OpenScene("Game");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}