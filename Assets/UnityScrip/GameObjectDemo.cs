using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDemo : MonoBehaviour
{

    public GameObject gO;
    public Transform bO;
    // Start is called before the first frame update
    void Start()
    {
        //print(gameObject);
        //print(gameObject.transform.position);
        //print(gO.transform.position);

        //print(bO.gameObject);

        print(gameObject.name);  //��ȡ���������
        print(gameObject.tag);  //��ȡ���������
        print(gameObject.activeInHierarchy);  //��ȡ�����״̬���Ƿ�򿪣�
        gO = GameObject.Find("B");  //�������ֲ�����Ϸ����
        print(gO.transform.position);

        Transform transform = gameObject.GetComponent<Transform>();  //��ȡ��Ϸ�����ϵ����<>��������������

        gameObject.SetActive(false);  // ��������״̬���������״̬����Ϊ����

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
