using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class DroppingIn : MonoBehaviour
    {
        [SerializeField] private GameObject SupplyOrb;
        [SerializeField] private GameObject PowderOrb;
        public Transform[] SpawnLocation;

        private void OnEnable()
        {
            EventTrigger.OrbDrop += Commence;
        }

        private void OnDisable()
        {
            EventTrigger.OrbDrop -= Commence;
        }

        private void Commence()
        {
            Debug.Log("Supply Drop Incoming!");
            Instantiate(SupplyOrb, SpawnLocation[0].transform.position, Quaternion.identity);
            Instantiate(PowderOrb, SpawnLocation[1].transform.position, Quaternion.identity);
        }
    }
}

