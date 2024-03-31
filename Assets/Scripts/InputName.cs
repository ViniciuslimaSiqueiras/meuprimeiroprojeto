using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public TMP_InputField inputField;

    private void Start()
    {
        inputField.onValueChanged.AddListener(updateName);
    }

    public void updateName(string name)
    {
        if (isPlayer)
            SaveControler.Instance.namePlayer = name;
        else
            SaveControler.Instance.nameEnemy = name;
        
    }

}
