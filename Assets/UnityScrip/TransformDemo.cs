using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDemo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print(transform.childCount);  //输出该对象的子对象个数
        print(transform.parent);  //输出该对象父对象的名字（transform类型）
        print(transform.position);  //输出该对象当前的位置信息

        transform.position =new Vector3(10, 10, 10);
        print(transform.position);
        transform.eulerAngles = new Vector3(10, 0, 0);

        print(transform.Find("Cube1"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
