using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public List<Text> listaTexto = new List<Text>();
    public InputField inputName;
    public Text textPontos;
    public int pontos;
    public Text nomeFinal;
    public string[] result;

    public int primeiro;
    public int segundo;
    public int terceiro;

    public Text primeiroTexto;
    public Text segundoTexto;
    public Text terceiroTexto;

    public Text[] texto;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textPontos.text = pontos.ToString();
    }

    public void aumentarPontos()
    {
        pontos += 1;
    }


    public void diminuirPontos()
    {
        if (pontos > 0)
        {
            pontos += -1;
        }

    }



    public void pegarNome()
    {
        result = new string[] { inputName.text };


        // nomeFinal.text = "O jogador " + result[0] + " fez " + textPontos.text + " pontos";

        //texto = new Text[] { nomeFinal };
        // primeiro.text = "O jogador " + nameString + " fez " + textPontos.text + " pontos";

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);


        if (int.Parse(textPontos.text) > primeiro)
        {
            primeiro = int.Parse(textPontos.text);
            primeiroTexto.text = result[0] + " " + textPontos.text + " pts";
        }



        else if (int.Parse(textPontos.text) > segundo)
        {
            segundo = int.Parse(textPontos.text);
            segundoTexto.text = result[0] + " " + textPontos.text + " pts";
        }


        else if (int.Parse(textPontos.text) > terceiro)
        {
            terceiro = int.Parse(textPontos.text);
            terceiroTexto.text = result[0] + " " + textPontos.text + " pts";
        }


    }



}
