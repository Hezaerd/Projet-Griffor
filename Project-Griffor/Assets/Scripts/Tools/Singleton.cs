using UnityEngine;
using UnityEngine.Assertions;

namespace ProjectGriffor
{
    public class Singleton : MonoBehaviour
    {
        public static Singleton instance { get; private set; }

        public StatsTracker gameManager { get; private set; }
        public QuestionsManager questionsManager { get; private set; }

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Debug.Log("Instance already exists, destroying object!");
                Destroy(this);
                return;
            }

            Assert.IsTrue(LoadManagers());

            instance = this;
            DontDestroyOnLoad(instance);
        }

        private bool LoadManagers()
        {
            questionsManager = GetComponentInChildren<QuestionsManager>();
            if (questionsManager)
                Debug.Log($"<color=#f7ba00>questionManager successfully loaded</color>");
            else
            {
                Debug.Log($"<color=#CE3312>Failed to find questionManager</color>");
                return false;
            }

            gameManager = GetComponentInChildren<StatsTracker>();
            if (gameManager)
                Debug.Log($"<color=#f7ba00>gameManager successfully loaded</color>");
            else
            {
                Debug.Log($"<color=#CE3312>Failed to find gameManager</color>");
                return false;
            }

            return true;
        }
    }
}