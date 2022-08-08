using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class Deletion : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Cube(Clone)")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
