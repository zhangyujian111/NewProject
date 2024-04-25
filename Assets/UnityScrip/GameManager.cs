using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo
{
    public string name;
    public string paseWord;
    public bool isMan;

    public UserInfo(string name, string paseWord, bool isMan)
    {
        this.name = name;
        this.paseWord = paseWord;
        this.isMan = isMan;
    }
}

public class GameManager
{
    private static GameManager instance;
    public List<UserInfo> UserInfos = new List<UserInfo>();

    public static GameManager Instance {
        get
        {
            if(instance == null) instance = new GameManager();
            return instance;
        }
    }

    public void SaveUserInfo(UserInfo userInfo)
    {
        UserInfos.Add(userInfo);
    }

    public UserInfo GetUserInfo(string name)
    {
        for (int i = 0; i < UserInfos.Count; i++)
        {
            if (UserInfos[i].name == name)
            {
                return (UserInfos[i]);
            }
        }
        return null;
    }
}
