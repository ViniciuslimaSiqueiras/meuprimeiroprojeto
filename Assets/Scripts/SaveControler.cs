using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveControler : MonoBehaviour
{
    public Color colorEnemy;
    public Color colorPlayer;

    private static SaveControler _instance;

    public string namePlayer;
    public string nameEnemy;


    public string savedWinnerKey = "savedWinner";
    public static SaveControler Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = FindObjectOfType<SaveControler>();
            }
            if(_instance == null)
            {
                GameObject singletonObject = new GameObject(typeof(SaveControler).Name);
                _instance = singletonObject.AddComponent<SaveControler>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);

    }

    public string GetName(bool isPlayer)
    {
        return isPlayer ? namePlayer : nameEnemy;
    }

    public void Reset()
    {
        nameEnemy = "";
        namePlayer = "";
        colorEnemy = Color.white;
        colorPlayer = Color.white;
    }
    public void SaveWinner(string winner)
    {
        PlayerPrefs.SetString(savedWinnerKey,winner);
    }

    public string GetLastWinner()
    {
        return PlayerPrefs.GetString(savedWinnerKey);
    }
    public void clearSave()
    {
        PlayerPrefs.DeleteAll();
    }

}
