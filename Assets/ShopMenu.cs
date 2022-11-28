using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject shopMenuUI;
    public GameObject pauseMenuUI;
    public void LoadStartMenu()
    {
        shopMenuUI.SetActive(false);
        //pauseMenuUI.SetActive(true);
        startMenuUI.SetActive(true);
    }
}
