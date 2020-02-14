using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lista : MonoBehaviour
{
    public List<GameObject> objetosList = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && objetosList.Count > 0)
        {
            Destroy(objetosList[objetosList.Count - 1]);
            objetosList.Remove(objetosList[objetosList.Count - 1]);
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject objetoTemporario = new GameObject("objeto vazio");
            objetosList.Add(objetoTemporario);
        }
    }
}
