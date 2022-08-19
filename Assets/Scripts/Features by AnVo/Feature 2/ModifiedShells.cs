using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiedShells : MonoBehaviour
{
    public GameObject explosionPrefab; // the explosion we want to spawn in
    public float damage = 5; 

    public delegate void TankRegister();
    public static event TankRegister HitTank;

    private void OnTriggerEnter(Collider other)
    {
        Boom();
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Tank>().tankHealth.CurrentHealth -= damage;
            HitTank();
        }

    }

    // Called when the shell has hit an object in our scene
    private void Boom()
    {
        // spawn in our explosion effect
        GameObject clone = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);

    }

    private void OnEnable()
    {
        HitTank += TrackingHit;
    }

    private void OnDisable()
    {
        HitTank -= TrackingHit;
    }

    private void TrackingHit()
    {
        Debug.Log("A 'Meteor' has hit a tank!");
    }
}

