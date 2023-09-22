using UnityEngine;

namespace ProjectGriffor
{
    [CreateAssetMenu(fileName = "Question", menuName = "Question")]
    public class Question : ScriptableObject
    {
        public string question;

        public Answer[] answers;
    }
}