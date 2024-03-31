using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsSelectButton : MonoBehaviour
{

    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = false;

    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPlayer)
        {
            //paddleReference.color = SaveControler.Instance.colorPlayer;
            SaveControler.Instance.colorPlayer = paddleReference.color;
            
        }
        else
        {
            //paddleReference.color = SaveControler.Instance.colorEnemy;
            SaveControler.Instance.colorEnemy = paddleReference.color;

        }
    }


}
