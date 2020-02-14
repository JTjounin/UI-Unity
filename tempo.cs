using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempo : MonoBehaviour
{
    public float timeStart;
    public Text textBox;

    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }

        else if (timeStart < 0)
        {
            timeStart = 5;
        }
    }
}