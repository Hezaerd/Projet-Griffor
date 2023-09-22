using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectGriffor
{
    public class SceneLoader : MonoBehaviour
    {
        static public void OpenScene(string pName)
        {
            // Use SceneManager.LoadSceneAsync to load the scene asynchronously
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(pName);

            // Subscribe to the completed callback
            asyncLoad.completed += OnSceneLoaded;
        }

        // Callback method to handle scene loading completion
        static private void OnSceneLoaded(AsyncOperation asyncOperation)
        {
            // Check if the operation was successful
            if (asyncOperation.isDone)
            {
                string loadedSceneName = SceneManager.GetActiveScene().name;
                Debug.Log($"<color=#00FF00>Successfuly loaded scene: {loadedSceneName}</color>");
            }
            else
            {
                Debug.Log($"<color=#CE3312>Failed to open scene</color>");
            }
        }
    }

}