using UnityEngine;

namespace ProjectGriffor
{
    public class InitGame : MonoBehaviour
    {
        private void Start()
        {
            Singleton.instance.questionsManager.ChangeQuestion();
            Debug.Log("<color=#2B97EB> Successfully started the first question !</color>");
            Destroy(this);
        }
    }
}