using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

namespace ProjectGriffor
{
    public class AnswersReciever : MonoBehaviour
    {
        [SerializeField] private int answersNumber;

        private void OnEnable()
        {
            Singleton.instance.questionsManager.OnQuestionChanged += QuestionChanged;
        }

        private void QuestionChanged()
        {
            Question currQuestion = Singleton.instance.questionsManager.questions[Singleton.instance.questionsManager.currQuestionIndex];

            answersNumber = currQuestion.answers.Length;

            Debug.Log($"The current question {currQuestion} have {answersNumber} answers");
        }
    }
}