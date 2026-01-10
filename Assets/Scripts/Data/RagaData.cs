using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ClinicalGames.Ragasutra
{
    public enum Prahar
    {
        FirstPrahar_Morning = 0,            //6AM - 9AM
        SecondPrahar_LateMorning = 1,       //9AM - 12PM
        ThridPrahar_Afternoon = 2,          //12PM - 03PM
        FourthPrahar_LateAfternoon = 3,     //03PM - 06PM
        FifthPrahar_Evening = 4,            //06PM - 09PM
        SixthPrahar_Night = 5,              //09PM - 12AM
        SeventhPrahar_LateNight = 6,        //12AM - 03AM
        EigthPrahar_Dawn = 7                //03AM - 06AM
    }

    [CreateAssetMenu(fileName = "ragaData", menuName = "Scriptable Objects/Data/Raga Data")]
    public class RagaData : ScriptableObject
    {
        [BoxGroup("Core Info", centerLabel: true)]
        [SerializeField] private string m_RagaName;
        [BoxGroup("Core Info")]
        [SerializeField] private Prahar m_TimeOfDay;

        [BoxGroup("Metadata for UI", centerLabel: true)]
        [SerializeField] private string m_Thaat;
        [BoxGroup("Metadata for UI")]
        [SerializeField] private string m_MoodDescription;

        [BoxGroup("Track Info", centerLabel: true)]
        [SerializeField] private List<RagaTrackInfo> m_AvailableTracks;

        public string RagaName => m_RagaName;
        public Prahar TimeOfDay => m_TimeOfDay;
        public string Thaat => m_Thaat;
        public string MoodDescription => m_MoodDescription;
        public List<RagaTrackInfo> AvailableTracks => m_AvailableTracks;
    }
}
