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
        Santoor
    }

    [System.Serializable]
    public class RagaTrackInfo
    {
        [BoxGroup("Audio Source", centerLabel: true)]
        [SerializeField] private AudioClip m_Clip;

        [BoxGroup("Artist Details", centerLabel: true)]
        [SerializeField] private string m_ArtistName;
        [SerializeField] private InstrumentType m_InstrumentType;

        [BoxGroup("Playback Settings", centerLabel: true)]
        [Range(0F, 1F)]
        [SerializeField] private float m_VolumeAdjustment;

        public AudioClip Clip => m_Clip;
        public string ArtistName => m_ArtistName;
        public InstrumentType Instrument => m_InstrumentType;
        public float VolumeAdjustment => m_VolumeAdjustment;
    }
}
