using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{

    public delegate void BaseDelegate();  //����һ��ί�У��е����Ʒ���
    //�����ģ��������Ρ��з���ֵ�ͷ��͵ȵ���ʽ���
    // Start is called before the first frame update
    void Start()
    {
        BaseDelegate Show = show1;  //��һ����������ί�ж���
        Show();   //ֱ�ӵ��ã������ں���
        Show.Invoke();   //����������ͬ
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void show1()   //����һ������
    {
        Debug.Log("show1������");
    }
}
