using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiedShells : MonoBehaviour
{
    public GameObject explosionPrefab; // the explosion we want to spawn in
    public float damage = 5; // the maximum amount of damage that my shell can do.
    public float maxShellLifeTime = 2; // how long should the shell live for before it goes boom!

    public delegate void AnnouceEnviron();
    public static AnnouceEnviron playerNumber;

    private void OnTriggerEnter(Collider other)
    {
        Boom();
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Tank>().tankHealth.CurrentHealth -= damage;
        }

    }

    // Called when the shell has hit an object in our scene
    private void Boom()
    {
        // spawn in our explosion effect
        GameObject clone = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);
        Destroy(clone, maxShellLifeTime);

    }
}

