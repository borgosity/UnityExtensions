using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionTester : MonoBehaviour
{
    private List<ITestGroup> testGroups = new List<ITestGroup>();

    private void OnEnable()
    {
        testGroups.Clear();
        testGroups.Add(new TestGroupPositionExtensions()); 
        
        foreach( ITestGroup testGroup in testGroups)
        {
            ExecuteTestGroup(testGroup);
        }
    }

    private void ExecuteTestGroup(ITestGroup testGroup)
    {
        testGroup.Initialize();
        testGroup.Run();
        testGroup.Results();
    }
}
