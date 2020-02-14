using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreHolder : MonoBehaviour
{

    public static string scoreString;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
