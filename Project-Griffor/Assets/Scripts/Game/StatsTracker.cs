using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ProjectGriffor
{
    public struct Datas
    {
        public int Score;
        public int ScoreMoral;
        public int ScoreDrogue;
        public int ScoreSexe;
        public int ScoreAlcool;
    }

    public class StatsTracker : MonoBehaviour
    {
        public Datas playerScores;
    }
}