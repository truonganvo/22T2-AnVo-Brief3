using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class Volcano : MonoBehaviour
    {
        public GameObject spawnVolcano;
        public void OnTriggerEnter(Collider other)
        {
            Instantiate(spawnVolcano, transform.position, Quaternion.identity);
            Debug.Log("YOU FOOL!!!! YOU DOOMED US ALL!!!!!");
        }


    }
}

