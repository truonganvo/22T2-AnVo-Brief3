using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Tank playerTank;
        [SerializeField] private Tank aiTank;

        private void Start()
        {
            aiTank = GetComponent<Tank>();
        }

        private void Update()
        {
            if (playerTank)
            {
                // Make our AI tank look towards the player's tank
                aiTank.transform.LookAt(playerTank.transform.position);

                // Make our AI tank move forward
                aiTank.tankMovement.HandleMovement(0.4f, 0f);
            }
        }
    }
}