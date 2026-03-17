using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenuDisabler : MonoBehaviour
{
    private GameObject saveMenu;
    private void Start()
    {
        saveMenu = GameObject.Find("SaveMenu");
    }

    public void DisableSaveMenu()
    {
        saveMenu.SetActive(false);
    }

    public void EnableSaveMenu()
    {
        saveMenu.SetActive(true);
    }
}
