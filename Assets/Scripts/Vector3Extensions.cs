using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Borgosity.Extenions
{
    public static class Vector3Extensions
    {
        public static float Distance(this Vector3 source, Vector3 destination)
        {
            return (source - destination).sqrMagnitude;
        }
    }
}
