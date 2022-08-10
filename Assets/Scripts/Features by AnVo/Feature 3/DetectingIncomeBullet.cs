using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingIncomeBullet : MonoBehaviour
{
    private GameObject bulletIncoming;
    private void OnTriggerEnter(Collider other)
    {
        bulletIncoming = GameObject.FindGameObjectWithTag("Bullet");
        Destroy(bulletIncoming);
    }
}
