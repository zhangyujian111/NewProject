using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��һ�������ʼ��
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        Debug.Log(array[4]);

        //�ڶ��������ʼ��
        int[] array1 = new int[] {1,2,3,4,5};
        Debug.Log(array1[3]);

        //����Ԫ���޸�
        array1[3] = 100;
        Debug.Log(array1[3]);

        //�����������ʼ��
        int[] array2 = {10,20,30,40,50};
        //��ʾ��������
        Debug.Log("���鳤��Ϊ: " + array2.Length);

        //��ά����
        int[,]array3 = new int[2,2];
        array3[0, 0] = 10;
        array3[0, 1] = 20;
        array3[1, 0] = 30;
        array3[1, 1] = 40;
        //��ȡ���鳤��
        Debug.Log(array3.Length);
        //��ȡ��ά��������������
        Debug.Log(array3.GetLength(0));
        Debug.Log(array3.GetLength(1));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
