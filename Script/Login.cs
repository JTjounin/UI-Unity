using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField nomeLogin;
    public InputField senhaLogin;

    public InputField nameRegistro;
    public InputField senhaRegistro;
    public InputField confirmarRegistro;

    public List<string> usuarios;
    public GameObject login;
    public GameObject registro;

    void Start()
    {
        login.SetActive(true);
        registro.SetActive(false);
    }

    public void Registrar()
    {
        if ((senhaRegistro.text == confirmarRegistro.text) && senhaRegistro.text != "")
        {
            usuarios.Add("nome : " + nameRegistro.text + " senha : " + senhaRegistro.text);

            login.SetActive(true);
            registro.SetActive(false);
        }
    }



    public void Log()
    {
        if ((nomeLogin.text == nameRegistro.text) && (nameRegistro.text != "") && (senhaLogin.text == senhaRegistro.text) && (senhaRegistro.text != ""))
        {

            SceneManager.LoadScene("Jogar");
        }
    }
}
