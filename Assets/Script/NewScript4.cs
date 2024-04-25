using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        func();
    }

    void func()
    {
        int a = 1;
        int b = 2;
        int c = a > b ? a - b : a + b;
        Debug.Log(c);
    }
}
