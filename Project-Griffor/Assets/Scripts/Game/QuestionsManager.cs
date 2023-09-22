using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;

namespace ProjectGriffor
{
    public class QuestionsManager : MonoBehaviour
    {
        [Header("Questions")]
        [Tooltip("Index of the current question")]
        public int currQuestionIndex = -1;

        [Space, Tooltip("List of all questions")]
        public Question[] questions;

        #region EVENTS

        [Header("Events")]
        [Space, Tooltip("Event called when question is changed")]
        public UnityEvent onQuestionChanged;

        public event UnityAction OnQuestionChanged
        {
            add => onQuestionChanged.AddListener(value);
            remove => onQuestionChanged.RemoveListener(value);
        }

        # endregion EVENTS

        private void Awake()
        {
            QuestionsLoader.LoadQuestions();

            Assert.IsTrue(QuestionsChecker.CheckQuestions());
        }

        public void ChangeQuestion()
        {
            currQuestionIndex++;
            onQuestionChanged?.Invoke();
        }
    }
}