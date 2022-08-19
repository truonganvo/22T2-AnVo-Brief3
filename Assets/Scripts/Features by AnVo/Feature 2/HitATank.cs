using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class HitATank : MonoBehaviour
    {
        private void OnEnable()
        {
            ModifiedShells.HitTank += TrackingHit;
        }

        private void OnDisable()
        {
            ModifiedShells.HitTank -= TrackingHit;
        }

        private void TrackingHit()
        {
            Debug.Log("A 'Meteor' has hit a tank!");
        }
    }
}

