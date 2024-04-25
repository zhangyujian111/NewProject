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

        print(gameObject.name);  //获取物体的名称
        print(gameObject.tag);  //获取物体的类型
        print(gameObject.activeInHierarchy);  //获取组件的状态（是否打开）
        gO = GameObject.Find("B");  //根据名字查找游戏物体
        print(gO.transform.position);

        Transform transform = gameObject.GetComponent<Transform>();  //获取游戏物体上的组件<>中填的是组件类型

        gameObject.SetActive(false);  // 设置物体状态，将物体的状态设置为隐藏

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
