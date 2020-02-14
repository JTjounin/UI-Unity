using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inicial : MonoBehaviour
{
    public InputField nameInicial;
    public InputField senhaInicial;
    public string nameText;
    public string senhaText;

    public Text primeiro;
    public Text segundo;
    public Text terceiro;


    // textPontos.text

    // Use this for initialization
    void Start()
    {
        // primeiro = texto[0];
        //segundo = texto[1];
        //terceiro = texto[2];
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void NomeSenha()
    {
        if ((nameInicial.text == nameText) && (senhaInicial.text == senhaText))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneManager.LoadScene("SampleScence");
        }
    }


}
