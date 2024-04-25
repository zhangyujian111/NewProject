using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface BaseInterface1
{
    public void Func1();
    public void Func2();
}

public interface BaseInterface2
{
    public void Func3();
    public void Func4();
}

public interface Base:BaseInterface1, BaseInterface2
{

}

public class MyClass11 : Base
{
    void BaseInterface1.Func1()
    {
        throw new System.NotImplementedException();
    }

    void BaseInterface1.Func2()
    {
        throw new System.NotImplementedException();
    }

    void BaseInterface2.Func3()
    {
        throw new System.NotImplementedException();
    }

    void BaseInterface2.Func4()
    {
        throw new System.NotImplementedException();
    }
}
public class Interface : MonoBehaviour
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
