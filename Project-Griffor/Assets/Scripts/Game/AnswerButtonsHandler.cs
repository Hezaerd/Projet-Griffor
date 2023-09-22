using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectGriffor
{
    public class AnswerButtonsHandler : MonoBehaviour
    {
        public GameObject buttonPrefab;
        public Transform buttonParent;

        private void OnEnable()
        {
            Singleton.instance.questionsManager.OnQuestionChanged += QuestionChanged;
        }

        private void QuestionChanged()
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            int answersNumber = Singleton.instance.questionsManager.questions[Singleton.instance.questionsManager.currQuestionIndex].answers.Length;

            
        }
    }
}