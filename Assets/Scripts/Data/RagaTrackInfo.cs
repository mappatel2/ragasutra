using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ClinicalGames.Ragasutra
{
    public enum InstrumentType
    {
        Vocal,
        Flute,
        Sitar, 
        Sarod, 
        Veena,
        Violin,
        Santoor,
        Tabla,
        Harmonium
    }

    [System.Serializable]
    public class RagaTrackInfo
    {
        [BoxGroup("General", centerLabel: true)]
        [SerializeField] private AudioClip m_Clip;
        [BoxGroup("General")]
        [SerializeField] private string m_ArtistName;
        [BoxGroup("General")]
        [Range(0F, 1F)]
        [SerializeField] private float m_VolumeAdjustment;
        [BoxGroup("General")]
        [SerializeField] private List<InstrumentType> m_Instruments;

        public AudioClip Clip => m_Clip;
        public string ArtistName => m_ArtistName;
        public List<InstrumentType> Instruments => m_Instruments;
        public float VolumeAdjustment => m_VolumeAdjustment;
        
#if UNITY_EDITOR

        /// <summary>
        /// Removes Duplicate Tags from the List
        /// Called By RagaData From OnValidate
        /// </summary>
        public void RemoveDuplicateTags()
        {
            if (m_Instruments != null && m_Instruments.Count > 0)
            {
                Dictionary<InstrumentType, bool> duplicates = new Dictionary<InstrumentType, bool>();
                for (int i = 0; i < m_Instruments.Count; i++)
                {
                    if (duplicates.ContainsKey(m_Instruments[i])) continue;
                    duplicates.Add(m_Instruments[i], true);
                }

                if (duplicates.Count == m_Instruments.Count) return;
                m_Instruments.Clear();
                foreach (InstrumentType instrumentType in duplicates.Keys)
                {
                    m_Instruments.Add(instrumentType);
                }
            }            
        }
        
#endif
    }
}
