using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBehaviour : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu", 10f);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("0 - MainMenu");
    }

}
