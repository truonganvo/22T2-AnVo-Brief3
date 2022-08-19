using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemyEvent : MonoBehaviour
{
    public delegate void FourWayMexi(int NumberToSpawn);
    public static event FourWayMexi EnemySpawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (EnemySpawn != null)
            {
                //EnemySpawn();
            }
        }

    }
}
