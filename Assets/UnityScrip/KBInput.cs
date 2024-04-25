using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KBInput : MonoBehaviour
{

    public string AttackKey;
    public int AttackValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region
        //if (Input.GetKeyDown(KeyCode.A))  //键盘按下
        //{
        //    print("你在按下了A");
        //}

        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    print("你在弹起了A");
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    print("你一直在按A");
        //}
        #endregion

        if (Input.GetKeyDown(AttackKey))  //键盘按下
        {
            print("你开始蓄力，攻击力上升");
            AttackValue += 1;
        }
        
        if (Input.GetKeyUp(AttackKey))
        {
            print("你发动了攻击");
            print("此时你的攻击力是" + AttackValue);
        }

        if (Input.GetKey(AttackKey))
        {
            print("你的攻击力在上升");
            if(AttackValue <= 100)
            {
                AttackValue += 1;
            }

        }
    }
}
