using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Borgosity.Extenions;

public class TestVector3Distance : Test
{
    float expectedResult = 3;
    float distance = 0;

    Vector3 source = Vector3.zero;
    Vector3 destination = Vector3.one;

    public override void Initialize()
    {
        testName = "Vector3 Distance";
    }

    public override bool Run()
    {
        distance = source.Distance(destination);
        return result = expectedResult == distance;
    }
}
