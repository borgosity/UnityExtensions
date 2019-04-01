using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Borgosity.Extenions;

public class TestVector3Distance : MonoBehaviour, ITest
{
    float expectedResult = 0;
    float distance = 0;

    Vector3 source = Vector3.zero;
    Vector3 destination = Vector3.one;

    public void Initialize()
    {

    }

    public bool Run()
    {
        distance = source.Distance(destination);
        return expectedResult == distance;
    }
}
