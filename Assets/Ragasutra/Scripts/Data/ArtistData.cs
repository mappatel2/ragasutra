using UnityEngine;

namespace Ragasutra.Scripts.Data
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
        Harmonium,
        Pakhawaj,
        Tanpura,
        Mridangam,
        RudraVeena
    }
    
    [CreateAssetMenu(fileName = "ArtistData", menuName = "Scriptable Objects/Data/Artist Data")]
    public class ArtistData : ScriptableObject
    {
        [SerializeField] private string m_ArtistName;
        [SerializeField] private InstrumentType m_Instrument;
        
        public string ArtistName => m_ArtistName;
        public InstrumentType Instrument => m_Instrument;
    }
}