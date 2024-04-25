using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleFunc : MonoBehaviour
{

    private void Awake()
    {
        print("awake");  //唤醒事件，在一开始就执行而且只执行一次
    }

    private void OnEnable()
    {
        print("onenable"); //启用事件，每次启用都会执行一次
    }
    // Start is called before the first frame update
    void Start()
    {
        print("start");  //开始事件，只执行一次
    }
    //前三者执行顺序为，awake、onenable、start. 其中awake 和 start 只执行一次，onenable可以执行多次



    // Update is called once per frame
    void Update()
    {
        print("update"); //每帧执行一次
    }

    private void FixedUpdate()
    {
        print("fixedupdate");  //固定更新，每0.02秒更新一次
    }

    private void LateUpdate()
    {
        print("lateupdate");  //与update更新频率一样，但在update后面执行
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnDestroy()
    {
        print("OnDestroy");  //销毁事件，每次销毁时执行一次，同时执行一次OnDisableO。因为在销毁前对象会被禁用
    }
}
