using UnityEngine;
using System.Collections;

public class ExtSomeClass : MonoBehaviour
{
    void Start()
    {
        transform.ResetTransformation();
        Debug.Log("Extension succesful");
    }
}