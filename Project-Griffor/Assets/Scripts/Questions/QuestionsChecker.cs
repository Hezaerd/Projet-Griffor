using System.Linq;
using UnityEngine;

namespace ProjectGriffor
{
    public class QuestionsChecker
    {
        public static bool CheckQuestions()
        {
            int validQuestions = 0;

            foreach (Question question in Singleton.instance.questionsManager.questions)
            {
                if (string.IsNullOrEmpty(question.question))
                {
                    Debug.LogError($"<color=#CE3312>Question {question.name} has no question</color>");
                    return false;
                }

                if (question.answers.Length <= 1)
                {
                    Debug.LogError($"<color=#CE3312>Question {question.name} don't have enough answers</color>");
                    return false;
                }

                foreach (Answer answer in question.answers)
                {
                    if (string.IsNullOrEmpty(answer.answer))
                    {
                        Debug.LogError($"<color=#CE3312>Question {question.name} has an answer with no text</color>");
                        return false;
                    }

                    if (answer.types.Length == 0)
                    {
                        Debug.LogError($"<color=#CE3312>Question {question.name} has an answer with no types</color>");
                        return false;
                    }

                    if (answer.types.Any(type => type.value == 0))
                    {
                        Debug.LogError($"<color=#CE3312>Question {question.name} has an answer with a type with a value <= 0</color>");
                        return false;
                    }
                }

                validQuestions++;
            }

            if (validQuestions == 0)
            {
                Debug.LogError($"<color=#CE3312>No valid questions found</color>");
                return false;
            }
            else
            {
                Debug.Log($"<color=#00FF00>Questions successfully loaded : {validQuestions} !</color>");
                return true;
            }
        }
    }
}