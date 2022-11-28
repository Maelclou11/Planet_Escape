using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject shopMenuUI;
    public GameObject pauseMenuUI;
    public GameManager gameManager;
    public GoingUp goingUp;
    public Score score;
    public Player player;

    private void Start()
    {
        startMenuUI.SetActive(true);
        goingUp.enabled = false;
        score.enabled = false;
        player.enabled = false;
    }

    public void StartGame()
    {
        startMenuUI.SetActive(false);
        score.enabled = true;
        player.enabled = true;
        goingUp.enabled = true;
    }

    public void LoadShoap()
    {
        startMenuUI.SetActive(false);
        //pauseMenuUI.SetActive(false);
        shopMenuUI.SetActive(true);
    }


}
