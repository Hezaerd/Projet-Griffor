using System;

namespace ProjectGriffor
{
    public enum EnumType
    {
        MORALE,
        SEXE,
        DROGUE,
        ALCOOL
    }

    [Serializable]
    public class AnswerType
    {
        public EnumType type;
        public int value;
    }
}