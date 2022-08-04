using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] float gameTimer = 90;

        private void CountDown()
        {
            gameTimer -= Time.deltaTime;
        }
    }
}
