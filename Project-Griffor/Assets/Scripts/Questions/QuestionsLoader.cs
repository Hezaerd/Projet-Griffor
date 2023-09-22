using UnityEngine;

namespace ProjectGriffor
{
    public class QuestionsLoader
    {
        public static void LoadQuestions()
        {
            Singleton.instance.questionsManager.questions = Resources.LoadAll<Question>("Questions");

            if (Singleton.instance.questionsManager.questions.Length == 0)
            {
                Debug.LogError("No questions found!");
                return;
            }

            Debug.Log($"<color=#f7ba00>Questions founds : {Singleton.instance.questionsManager.questions.Length}</color>");
        }
    }
}