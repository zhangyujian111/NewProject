using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelScript1 : MonoBehaviour
{
    public static MainPanelScript1 Instance;
    private Button logButton;  //定义登录和注册按钮
    private Button registerButton;

    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        //registerButton = GameObject.Find("Regisetr").GetComponent<Button>();
        registerButton = transform.Find("Register").GetComponent<Button>();
        //logButton = GameObject.Find("Log").GetComponent<Button>();
        logButton = transform.Find("Log").GetComponent<Button>();

        registerButton.onClick.AddListener(registerButtonClick);  //给两个按钮带上监听事件
        logButton.onClick.AddListener(logButtonClick);

    }

    private void registerButtonClick()  //定义两个按钮事件
    {

        //打开注册面板
        RegisterPanelScrip.Instance.Show();
        gameObject.SetActive(false);
    }

    public void logButtonClick()
    {
        //打开登录面板
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }


}
