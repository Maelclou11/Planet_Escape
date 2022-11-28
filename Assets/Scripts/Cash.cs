using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    public Text textCash;
    public Animator animationBrokie;

    void Start()
    {
        textCash.text = PlayerPrefs.GetInt("Cash", 0).ToString("0$");
    }

    private void FixedUpdate()
    {
        textCash.text = PlayerPrefs.GetInt("Cash", 0).ToString("0$");
    }

    public void AddCash(int numberToAdd)
    {
        PlayerPrefs.SetInt("Cash", (PlayerPrefs.GetInt("Cash", 0) + numberToAdd));
    }

    public void ResetMoney()
    {
        PlayerPrefs.DeleteKey("Cash");
    }

    public void Buy(int cost)
    {
        if (cost < PlayerPrefs.GetInt("Cash", 0))
        {
            PlayerPrefs.SetInt("Cash", PlayerPrefs.GetInt("Cash", 0) - cost);
        } else
        {
            animationBrokie.enabled = true;
            Invoke("BrokeOff", 2);
        }
    }

    public void BrokeOff()
    {
        animationBrokie.enabled = false;
    }
}
