using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class MeteorFall : MonoBehaviour
    {
        public GameObject meteorFall;

        public float frequency;

        public float initialSpeed;

        float lastSpawnTime;

        public void Update()
        {
            if (Time.time > lastSpawnTime + frequency)
            {
                Spawn();
                lastSpawnTime = Time.time;
            }
        }

        public void Spawn()
        {
            Vector3 randomPos = new Vector3(Random.Range(-40, 40), 30, Random.Range(-40, 40));
            Instantiate(meteorFall, randomPos, Quaternion.identity);

        }
    }
}

