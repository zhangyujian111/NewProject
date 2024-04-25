using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleFunc : MonoBehaviour
{

    private void Awake()
    {
        print("awake");  //�����¼�����һ��ʼ��ִ�ж���ִֻ��һ��
    }

    private void OnEnable()
    {
        print("onenable"); //�����¼���ÿ�����ö���ִ��һ��
    }
    // Start is called before the first frame update
    void Start()
    {
        print("start");  //��ʼ�¼���ִֻ��һ��
    }
    //ǰ����ִ��˳��Ϊ��awake��onenable��start. ����awake �� start ִֻ��һ�Σ�onenable����ִ�ж��



    // Update is called once per frame
    void Update()
    {
        print("update"); //ÿִ֡��һ��
    }

    private void FixedUpdate()
    {
        print("fixedupdate");  //�̶����£�ÿ0.02�����һ��
    }

    private void LateUpdate()
    {
        print("lateupdate");  //��update����Ƶ��һ��������update����ִ��
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnDestroy()
    {
        print("OnDestroy");  //�����¼���ÿ������ʱִ��һ�Σ�ͬʱִ��һ��OnDisableO����Ϊ������ǰ����ᱻ����
    }
}
