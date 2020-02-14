using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void jogar()
    {
        SceneManager.LoadScene("jogo");
    }

    public void sair()
    {
        SceneManager.LoadScene("Menu");
    }

}
