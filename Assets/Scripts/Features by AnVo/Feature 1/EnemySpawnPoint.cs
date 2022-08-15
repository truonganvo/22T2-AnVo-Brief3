using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class EnemySpawnPoint : MonoBehaviour
    {
        public List<Transform> allEnemyPossibleSpawnPoints = new List<Transform>(); 
        public List<GameObject> EnemytankPrefabs = new List<GameObject>(); 

        private void OnEnable()
        {
            TriggerEnemyEvent.EnemySpawn += DroppingIn;
        }

        private void OnDisable()
        {
            TriggerEnemyEvent.EnemySpawn -= DroppingIn;
        }

        private void DroppingIn(int NumberToSpawn)
        {
            for (int i = 0; i < NumberToSpawn; i++)
            {
                Transform aiSpawnPoint = allEnemyPossibleSpawnPoints[Random.Range(0, allEnemyPossibleSpawnPoints.Count)];
                Instantiate(EnemytankPrefabs[i], aiSpawnPoint.position, EnemytankPrefabs[i].transform.rotation);
                allEnemyPossibleSpawnPoints.Remove(aiSpawnPoint);
            }

        }
    }
}
