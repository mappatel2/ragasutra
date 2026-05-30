using UnityEngine;

namespace Ragasutra.Scripts.Data
{
    [CreateAssetMenu(fileName = "ArtistData", menuName = "Scriptable Objects/Data/Artist Data")]
    public class ArtistData : ScriptableObject
    {
        [SerializeField] private string m_ArtistName;
        [SerializeField] private InstrumentType m_Instrument;
        
        public string ArtistName => m_ArtistName;
        public InstrumentType Instrument => m_Instrument;
    }
}