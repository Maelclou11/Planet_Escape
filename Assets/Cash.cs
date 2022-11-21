using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    public Text textCash;
    private int cashAmount; // = 20
    // Start is called before the first frame update
    void Start()
    {
        textCash.text = "0$";
    }

    private void Update()
    {
        textCash.text = cashAmount.ToString("0$");
    }

    public void Ajouter(int numberToAdd)
    {
        cashAmount = cashAmount + numberToAdd;
    }
}
