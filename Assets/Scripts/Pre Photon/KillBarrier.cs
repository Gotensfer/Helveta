using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrePhoton
{
    public class KillBarrier : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
        }
    }
}
