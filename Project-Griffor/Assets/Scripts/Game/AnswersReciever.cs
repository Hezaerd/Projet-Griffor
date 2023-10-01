using UnityEngine;

namespace ProjectGriffor
{
    public class AnswersReciever : MonoBehaviour
    {
        private GameObject[] buttons;

        private void OnEnable()
        {
            Singleton.instance.questionsManager.OnQuestionChanged += QuestionChanged;
        }

        private void QuestionChanged()
        {
            Question currQuestion = Singleton.instance.questionsManager.questions[Singleton.instance.questionsManager.currQuestionIndex];

            int answersNumber = currQuestion.answers.Length;
            InstantiateButtons(answersNumber);

            Debug.Log($"The current question {currQuestion} have {answersNumber} answers");
        }

        private void InstantiateButtons(int answersNumber)
        {
            for (int i = 0; i < answersNumber; i++)
            {
                GameObject button = Instantiate(Singleton.instance.questionsManager.buttonPrefab, Singleton.instance.questionsManager.buttonParent.transform);
                button.name = $"Button {i}";
                button.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Singleton.instance.questionsManager.questions[Singleton.instance.questionsManager.currQuestionIndex].answers[i].answer;
            }
        }
    }
}