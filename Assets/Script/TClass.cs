using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyClass15
{
    private int[] m_array;
    public MyClass15(int size)
    {
        m_array = new int[size];
    }

    public void set(int index,int value)
    {
        m_array[index] = value;
    }

    public int get(int index)
    {
        return m_array[index];
    }
}
public class TClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
