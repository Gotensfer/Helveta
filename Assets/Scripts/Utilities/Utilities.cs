using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrePhoton
{
    public static class Utilities
    {
        public static Vector2 CartesianToPolar(Vector2 cartesianVector)
        {
            float x = cartesianVector.x;
            float y = cartesianVector.y;
            float magnitude = cartesianVector.magnitude;

            return new Vector2(magnitude, Mathf.Atan(y / x));
        }

        public static Vector2 PolarToCartesian(Vector2 polarVector)
        {
            float x = polarVector.x;
            float y = polarVector.y;

            return new Vector2(x * Mathf.Cos(y), x * Mathf.Sin(y));
        }
    }
}
