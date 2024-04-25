using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelScript1 : MonoBehaviour
{
    public static MainPanelScript1 Instance;
    private Button logButton;  //�����¼��ע�ᰴť
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

        registerButton.onClick.AddListener(registerButtonClick);  //��������ť���ϼ����¼�
        logButton.onClick.AddListener(logButtonClick);

    }

    private void registerButtonClick()  //����������ť�¼�
    {

        //��ע�����
        RegisterPanelScrip.Instance.Show();
        gameObject.SetActive(false);
    }

    public void logButtonClick()
    {
        //�򿪵�¼���
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }


}
