using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buyable : MonoBehaviour
{
    public Text costText;
    public Cash cash;

    private void OnMouseDown()
    {
        int cost = int.Parse(costText.text);
        cash.Buy(cost);
    }
}
