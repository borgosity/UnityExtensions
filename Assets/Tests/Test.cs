using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Test
{
    public string testName = "Test Base";
    public bool result = false;
    public abstract void Initialize();
    public abstract bool Run();
}
