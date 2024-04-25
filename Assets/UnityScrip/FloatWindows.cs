using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatWindows : MonoBehaviour
{

    public static FloatWindows Instance;  //����ģʽ
    private Text info;
    private Button okButton;

    private void Awake()
    {
        Instance = this;

        info = transform.Find("Info").GetComponent<Text>();
        okButton = transform.Find("OkButton").GetComponent <Button>();
        okButton.onClick.AddListener(OkButtonClick);
        OkButtonClick();
    }
    
    public void ShowInfo(string inf)
    {
        gameObject.SetActive(true);
        info.text = inf;
    }
    private void OkButtonClick()
    {
        gameObject.SetActive(false);
    }

}
