using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class DetectingIncomeBullet : MonoBehaviour
    {
        public GameObject Object;
        public float healthPoint;
        private GameObject bulletIncoming;

        public delegate void DestroyedBuilding();
        public static DestroyedBuilding Remains;
        public int buildingAmount = 20;
        private void OnTriggerEnter(Collider other)
        {
            bulletIncoming = GameObject.FindGameObjectWithTag("Bullet");
            Destroy(bulletIncoming);

            healthPoint -= 10f;
            if (healthPoint <= 0)
            {
                Destroy(Object);
                if (Remains != null)
                {
                    Remains();
                }
            }
        }

        private void OnEnable()
        {
            Remains += CollideBuilding;
        }

        private void OnDisable()
        {
            Remains -= CollideBuilding;
        }

        private void CollideBuilding()
        {
            buildingAmount -= 1;
            Debug.Log("Number of building remains: " + buildingAmount);
        }
    }
}

