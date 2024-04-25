using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)  //触发进入
    {
        if(collision.gameObject.tag == "fair")
        {
            print("你进入了火中");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)  //触发中
    {
        if (collision.gameObject.tag == "fair")
        {
            print("你一直在火中");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)  //触发退出
    {
        if (collision.gameObject.tag == "fair")
        {
            print("你离开了火");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            print("玩家落到地面了");
        }
    }

}
