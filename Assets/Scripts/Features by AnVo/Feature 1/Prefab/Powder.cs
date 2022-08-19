using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class Powder : MonoBehaviour
    {
        [SerializeField] private GameObject NitroSupply;
        private float IncreaseSpeed = 3f;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(NitroSupply);
                collision.gameObject.GetComponent<Tank>().tankMovement.speed += IncreaseSpeed;
            }
        }
    }
}
