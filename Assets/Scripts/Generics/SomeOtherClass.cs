using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();
        myClass.GenericMethod<int>(5);
    }
}