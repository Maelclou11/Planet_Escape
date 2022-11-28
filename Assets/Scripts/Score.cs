using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (Time.timeSinceLevelLoad - time).ToString("0");
    }
}
