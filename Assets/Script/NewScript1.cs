using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string iName = "������";
        int iLevel = 12;
        int iIpValue = 1200;
        double iExp = 1000;
        Debug.LogFormat("����:{0},�ȼ�:{1},Ѫ��:{2},����ֵ:{3}", iName, iLevel, iIpValue, iExp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
