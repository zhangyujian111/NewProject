using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string iName = "大树人";
        int iLevel = 12;
        int iIpValue = 1200;
        double iExp = 1000;
        Debug.LogFormat("名字:{0},等级:{1},血量:{2},经验值:{3}", iName, iLevel, iIpValue, iExp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
