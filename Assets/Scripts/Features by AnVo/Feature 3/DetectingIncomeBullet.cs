using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingIncomeBullet : MonoBehaviour
{
    public GameObject Object;
    public float healthPoint;
    private GameObject bulletIncoming;
    private void OnTriggerEnter(Collider other)
    {
        bulletIncoming = GameObject.FindGameObjectWithTag("Bullet");
        Destroy(bulletIncoming);

        healthPoint -= 10f;
        if (healthPoint <= 0)
        {
          Destroy(Object);
        }
    }
}
