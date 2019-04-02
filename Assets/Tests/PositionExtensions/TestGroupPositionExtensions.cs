using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGroupPositionExtensions : ITestGroup
{
    private List<Test> tests = new List<Test>();
    private List<bool> results = new List<bool>();
    private bool groupResult = true;

    public void Initialize()
    {
        tests.Add(new TestVector3Distance());
    }

    public void Run()
    {
        foreach(Test test in tests)
        {
            bool result = test.Run();
            groupResult = groupResult && result ? true : false;
            results.Add(result);
        }
    }

    public void Results()
    {
        Debug.Log("Overall result: " + ResultText(groupResult));
        foreach(Test test in tests)
        {
            Debug.Log("Test: " + test.testName + " = " + ResultText(test.result) );
        }

    }

    private string ResultText(bool result)
    {
        return result ? "<color=green> PASS </color>" : "<color=red> FAIL </color>";
    }
}
