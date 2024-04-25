using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDemo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print(transform.childCount);  //����ö�����Ӷ������
        print(transform.parent);  //����ö��󸸶�������֣�transform���ͣ�
        print(transform.position);  //����ö���ǰ��λ����Ϣ

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
