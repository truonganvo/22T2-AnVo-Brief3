using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class EventTrigger : MonoBehaviour
    {
        public delegate void SupplyDrop();
        public static event SupplyDrop OrbDrop;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                OrbDrop();
            }
        }
    }
}