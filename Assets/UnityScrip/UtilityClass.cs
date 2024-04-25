using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region  时间工具类
        print(Mathf.Abs(-6));  //返回参数的绝对值  6
        print(Mathf.Max(1, 2, 3, 4));  //返回参数中的最大值  4
        print(Mathf.Min(1, 2, 3, 4));  //返回参数中的最小值  1
        print(Mathf.Round(1.2f));  //传入float数，返回四舍五入后得到的值  1
        print(Mathf.Round(1.6f));  //传入float数，返回四舍五入后得到的值  2
        print(Mathf.Ceil(1.3f));  //传入float数，返回向上取整得到的值  2
        print(Mathf.Floor(1.3f));  //传入float数，返回向下取整得到的值  1

        int a = Random.Range(0, 5);   //返回0-4中的随机值，不包含5 int型,
        float b = Random.Range(0, 5.0f);   //返回0-5中的随机值 float型  包含5
        for (int i = 0; i < 10; i++)
        {
            print(Random.Range(0, 5.0f));
        }
        #endregion
    }


}
