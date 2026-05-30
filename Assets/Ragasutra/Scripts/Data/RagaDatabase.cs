using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Ragasutra.Scripts.Data
{
    [CreateAssetMenu(fileName = "RagaDatabase", menuName = "Scriptable Objects/Data/Raga Database")]
    public class RagaDatabase : ScriptableObject
    {
        [ListDrawerSettings(ShowIndexLabels = true, ListElementLabelName = "RagaName")]
        [SerializeField] private List<RagaData> m_RagaDataList = new List<RagaData>();

        public bool TryGetRagasForPrahar(Prahar prahar, out List<RagaData> ragas)
        {
            ragas = new List<RagaData>();
            foreach (var ragaData in m_RagaDataList)
            {
                if (ragaData.Prahar == prahar)
                {
                    if (ragas.Contains(ragaData)) continue;
                    ragas.Add(ragaData);
                }
            }

            if (ragas.Count < 1)
            {
                ragas = null;
                return false;
            }

            return true;
        }
    }
}
