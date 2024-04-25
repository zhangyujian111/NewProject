using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBInput : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            print("鼠标左键按下");
            print(Input.mousePosition);  //显示鼠标的坐标
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标左键弹起");
        }

        if (Input.GetMouseButton(0))
        {
            print("鼠标左键持续按下");
        }
    }
}
