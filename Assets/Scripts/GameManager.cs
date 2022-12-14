using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 5f;
    public Score score;
    public GameObject completeLevelUI;
    public GameObject[] arrayLevels;
    public float distanceToSpawn = 6f;
    public GameObject startMenuUI;

    private GoingUp goingUp;
    private List<GameObject> listLevels = new List<GameObject>();

    private void Start()
    {
        startMenuUI.SetActive(true);
        goingUp = FindObjectOfType<GoingUp>();
        if (arrayLevels.Length < 0)
        {
            Debug.Log("wtf");
        }
        else
        {
            for (int i = 0; i < arrayLevels.Length; i++)
            {
                listLevels.Add(arrayLevels[i]);
            }
        }
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            score.enabled = false;
            goingUp.enabled = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        score.enabled = true;
        goingUp.enabled = true;
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public GameObject OneUniqueLevel()
    {
        int randomLevelIndex = Random.Range(0, listLevels.Count);
        GameObject tempLevel = listLevels[randomLevelIndex];
        listLevels.RemoveAt(randomLevelIndex);
        return tempLevel;
    }
}
