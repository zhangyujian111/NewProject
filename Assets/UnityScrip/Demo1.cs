using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{

    private void OnCollisionExit2D(Collision2D collision)  //碰撞结束时
    {
        print("碰撞结束了");
    }
    private void OnCollisionEnter2D(Collision2D collision)  //碰撞时
    {
        print("碰撞了" + "我碰到的是" + collision.gameObject.name);
    }
    private void OnCollisionStay2D(Collision2D collision)  //碰撞过程中
    {
        print("在碰撞ing");
    }
}
