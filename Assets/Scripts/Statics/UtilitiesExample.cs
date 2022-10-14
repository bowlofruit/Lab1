using UnityEngine;
using System.Collections;
using System;

public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        int x = Utilities.Add(10, 26);
        Debug.Log(x);
    }
}