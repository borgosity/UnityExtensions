using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGroupPositionExtensions : MonoBehaviour, ITestGroup
{
    private List<ITest> tests = new List<ITest>();
    private List<bool> results = new List<bool>();
    private bool groupResult = true;

    public void Initialize()
    {
        tests.Add(new TestVector3Distance());
    }

    public void Run()
    {
        foreach(ITest test in tests)
        {
            bool result = test.Run();
            groupResult = groupResult && result ? true : false;
            results.Add(result);
        }
    }

    public void Results()
    {
        Debug.Log("Overall result: " + groupResult);
        foreach(ITest test in tests)
        {
            Debug.Log("Test: ");
        }

    }
}
