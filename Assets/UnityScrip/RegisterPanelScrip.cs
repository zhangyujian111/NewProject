using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterPanelScrip : MonoBehaviour
{
    public static RegisterPanelScrip Instance;

    private InputField userName;
    private InputField paseWord;
    private InputField repaseWord;
    private Toggle isMan;
    private Button backButton;
    private Button okButton;

    private void Awake()
    {
        Instance = this;

        userName = GameObject.Find("UserName/InputField").GetComponent<InputField>();
        paseWord = GameObject.Find("PaseWord/InputField").GetComponent<InputField>();
        repaseWord = GameObject.Find("RePaseWord/InputField").GetComponent<InputField>();
        isMan = GameObject.Find("GenderGroup/Man").GetComponent<Toggle>();

        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        okButton = GameObject.Find("OkButton").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        okButton.onClick.AddListener(OkButtonClick);

        gameObject.SetActive(false);
    }


    private void BackButtonClick()
    {
        //返回主面板
        MainPanelScript1.Instance.Show();
        gameObject.SetActive(false);
    }

    private void OkButtonClick()
    {
        //确定注册

        if (string.IsNullOrEmpty(userName.text)
            || string.IsNullOrEmpty(paseWord.text)
            || string.IsNullOrEmpty(repaseWord.text))
        {
            FloatWindows.Instance.ShowInfo("请输入账号和密码");
        }else if (paseWord.text != repaseWord.text)
        {
            FloatWindows.Instance.ShowInfo("密码不一致");
        }
        else
        {
            if(GameManager.Instance.GetUserInfo(userName.text) != null){
                FloatWindows.Instance.ShowInfo("该用户已存在，请勿重复注册");
            }
            else
            {
                UserInfo userInfo = new UserInfo(userName.text, paseWord.text, isMan.isOn);
                GameManager.Instance.SaveUserInfo(userInfo);
                FloatWindows.Instance.ShowInfo("注册成功,请登录");
            }
;
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

}
