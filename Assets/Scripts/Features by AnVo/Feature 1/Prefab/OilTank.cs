using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class OilTank : MonoBehaviour
    {
        [SerializeField] private GameObject HealthSupply;
        private float IncreaseHealth = 15f;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(HealthSupply);
                collision.gameObject.GetComponent<Tank>().tankHealth.CurrentHealth += IncreaseHealth;
            }
        }
    }
}

