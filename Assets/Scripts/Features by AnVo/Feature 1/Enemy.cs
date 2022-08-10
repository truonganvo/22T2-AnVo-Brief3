using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AnVo
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private GameObject playerTank;
        private void Start()
        {

        }

        private void Update()
        {
            transform.LookAt(playerTank.transform);
        }
    }
}