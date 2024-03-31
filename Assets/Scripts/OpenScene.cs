using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public string scene;

    public void ChargeScene()
    {
        SceneManager.LoadScene(scene);

    }

}
