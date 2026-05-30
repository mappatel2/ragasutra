using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Ragasutra.Scripts.Data
{
    public enum Prahar
    {
        Morning = 0,            //6AM - 9AM
        LateMorning = 1,        //9AM - 12PM
        Afternoon = 2,          //12PM - 03PM
        LateAfternoon = 3,      //03PM - 06PM
        Evening = 4,            //06PM - 09PM
        Night = 5,              //09PM - 12AM
        LateNight = 6,          //12AM - 03AM
        Dawn = 7                //03AM - 06AM
    }

    [CreateAssetMenu(fileName = "ragaData", menuName = "Scriptable Objects/Data/Raga Data")]
    public class RagaData : ScriptableObject
    {
        [BoxGroup("Core Info", centerLabel: true)]
        [SerializeField] private string m_RagaName;
        [BoxGroup("Core Info")]
        [SerializeField] private Prahar m_Prahar;

        [BoxGroup("Metadata for UI", centerLabel: true)]
        [SerializeField] private string m_Thaat;
        [BoxGroup("Metadata for UI")]
        [SerializeField] private string m_MoodDescription;

        [BoxGroup("Track Info", centerLabel: true)]
        [SerializeField] private List<RagaTrackInfo> m_AvailableTracks;

        public string RagaName => m_RagaName;
        public Prahar Prahar => m_Prahar;
        public string Thaat => m_Thaat;
        public string MoodDescription => m_MoodDescription;
        public List<RagaTrackInfo> AvailableTracks => m_AvailableTracks;
    }
}
