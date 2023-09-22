using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace ProjectGriffor
{
    public class SceneSwapper : Editor
    {
        [MenuItem("Scenes/Main Menu _%&h")]
        public static void OpenMainMenuScene()
        {
            EditorSceneLoader.OpenScene("MainMenu");
        }

        [MenuItem("Scenes/Game _%&g")]
        public static void OpenGameScene()
        {
            EditorSceneLoader.OpenScene("Game");
        }
    }
}