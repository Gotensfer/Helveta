using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrePhoton
{
    public enum BarrierOrientation
    {
        Vertical,
        Horizontal
    }

    public class BounceBarrier : MonoBehaviour
    {
        [SerializeField] BarrierOrientation orientation;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.parent.TryGetComponent(out Bullet bullet))
            {
                bullet.bulletLife--;
                if (bullet.bulletLife == 0)
                {
                    Destroy(bullet.gameObject);
                }

                switch (orientation)
                {
                    case BarrierOrientation.Vertical:
                        bullet.movementVector.x *= -1;
                        break;

                    case BarrierOrientation.Horizontal:
                        bullet.movementVector.y *= -1;
                        break;
                }
            }
        }
    }
}

