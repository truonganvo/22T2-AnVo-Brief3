using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiedShells : MonoBehaviour
{
    public GameObject explosionPrefab; // the explosion we want to spawn in
    public float damage = 5; // the maximum amount of damage that my shell can do.
    public float maxShellLifeTime = 2; // how long should the shell live for before it goes boom!

    private void OnCollisionEnter(Collision collision)
    {
        Boom();
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("I hit the player!!");
        }
    }
    /// <summary>
    /// Called when the shell has hit an object in our scene
    /// </summary>
    private void Boom()
    {
        // spawn in our explosion effect
        GameObject clone = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);
        Destroy(clone, maxShellLifeTime);

    }
}

