using System.Collections.Generic;
using UnityEngine;

namespace Ragasutra.Scripts.Data
{
    [System.Serializable]
    public class RagaTrackInfo
    {
        [SerializeField] private AudioClip m_Clip;
#if UNITY_EDITOR
        [SerializeField] private string m_YoutubeUrl;
#endif
        [SerializeField] private List<ArtistData> m_Performers;

        public AudioClip Clip => m_Clip;
        public IReadOnlyList<ArtistData> Performers => m_Performers;
    }
}
