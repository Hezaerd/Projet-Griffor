using UnityEditor;

namespace ProjectGriffor
{
    public class StartOnMenu : EditorWindow
    {
        [MenuItem("Play/Play _%h")]
        public static void Play()
        {
            EditorSceneLoader.OpenScene("MainMenu");
            EditorApplication.isPlaying = true;
        }

    }
}
