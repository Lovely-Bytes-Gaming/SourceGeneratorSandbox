using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeSingleton
{
    private static SomeSingleton instance;
    public static SomeSingleton Instance => instance ??= new SomeSingleton();

    private SomeSingleton() { }

    public void Greet()
    {
        Debug.Log("Hello from some singleton!");
    }
}
