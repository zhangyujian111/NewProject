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
        //���������
        MainPanelScript1.Instance.Show();
        gameObject.SetActive(false);
    }

    private void OkButtonClick()
    {
        //ȷ��ע��

        if (string.IsNullOrEmpty(userName.text)
            || string.IsNullOrEmpty(paseWord.text)
            || string.IsNullOrEmpty(repaseWord.text))
        {
            FloatWindows.Instance.ShowInfo("�������˺ź�����");
        }else if (paseWord.text != repaseWord.text)
        {
            FloatWindows.Instance.ShowInfo("���벻һ��");
        }
        else
        {
            if(GameManager.Instance.GetUserInfo(userName.text) != null){
                FloatWindows.Instance.ShowInfo("���û��Ѵ��ڣ������ظ�ע��");
            }
            else
            {
                UserInfo userInfo = new UserInfo(userName.text, paseWord.text, isMan.isOn);
                GameManager.Instance.SaveUserInfo(userInfo);
                FloatWindows.Instance.ShowInfo("ע��ɹ�,���¼");
            }
;
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

}
