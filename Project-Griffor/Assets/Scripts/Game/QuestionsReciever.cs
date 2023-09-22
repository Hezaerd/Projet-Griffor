using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectGriffor
{
    public class QuestionsReciever : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI text;

        private void Awake()
        {
            text = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            Singleton.instance.questionsManager.OnQuestionChanged += ChangeQuestionText;
        }

        private void ChangeQuestionText()
        {
            Question currQuestion = Singleton.instance.questionsManager.questions[Singleton.instance.questionsManager.currQuestionIndex];

            text.text = currQuestion.question.ToString();
        }
    }
}