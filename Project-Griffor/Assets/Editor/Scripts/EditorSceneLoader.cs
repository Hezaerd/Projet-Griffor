using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace ProjectGriffor
{
    public class EditorSceneLoader : Editor
    {
        static public void OpenScene(string pName)
        {
            // Save currently opened scenes
            EditorSceneManager.SaveOpenScenes();

            // Open the scene
            EditorSceneManager.OpenScene($"Assets/Scenes/{pName}.unity");
            UnityEditor.SceneManagement.EditorSceneManager.sceneOpened += OnOpenedScene;
        }
        
        static private void OnOpenedScene(UnityEngine.SceneManagement.Scene scene, UnityEditor.SceneManagement.OpenSceneMode mode)
        {
            string loadedSceneName = EditorSceneManager.GetActiveScene().name;
            Debug.Log($"<color=#00FF00>Successfuly loaded scene: {loadedSceneName}</color>");
        }

    }
}
