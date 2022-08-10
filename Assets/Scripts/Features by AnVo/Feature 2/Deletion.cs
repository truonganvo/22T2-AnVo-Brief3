using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class Deletion : MonoBehaviour
    {
        //Incase the Cube spawn OUTSIDE the playzone.
        //If not then there's nothing to worry.
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Cube(Clone)")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
