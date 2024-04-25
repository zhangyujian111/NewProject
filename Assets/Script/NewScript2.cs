using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //第一种数组初始化
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        Debug.Log(array[4]);

        //第二种数组初始化
        int[] array1 = new int[] {1,2,3,4,5};
        Debug.Log(array1[3]);

        //数组元素修改
        array1[3] = 100;
        Debug.Log(array1[3]);

        //第三种数组初始化
        int[] array2 = {10,20,30,40,50};
        //显示数组容量
        Debug.Log("数组长度为: " + array2.Length);

        //二维数组
        int[,]array3 = new int[2,2];
        array3[0, 0] = 10;
        array3[0, 1] = 20;
        array3[1, 0] = 30;
        array3[1, 1] = 40;
        //获取数组长度
        Debug.Log(array3.Length);
        //获取二维数组行数和列数
        Debug.Log(array3.GetLength(0));
        Debug.Log(array3.GetLength(1));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
