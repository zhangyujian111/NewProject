using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region  ʱ�乤����
        print(Mathf.Abs(-6));  //���ز����ľ���ֵ  6
        print(Mathf.Max(1, 2, 3, 4));  //���ز����е����ֵ  4
        print(Mathf.Min(1, 2, 3, 4));  //���ز����е���Сֵ  1
        print(Mathf.Round(1.2f));  //����float�����������������õ���ֵ  1
        print(Mathf.Round(1.6f));  //����float�����������������õ���ֵ  2
        print(Mathf.Ceil(1.3f));  //����float������������ȡ���õ���ֵ  2
        print(Mathf.Floor(1.3f));  //����float������������ȡ���õ���ֵ  1

        int a = Random.Range(0, 5);   //����0-4�е����ֵ��������5 int��,
        float b = Random.Range(0, 5.0f);   //����0-5�е����ֵ float��  ����5
        for (int i = 0; i < 10; i++)
        {
            print(Random.Range(0, 5.0f));
        }
        #endregion
    }


}
