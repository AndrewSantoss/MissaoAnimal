using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmManutencao : MonoBehaviour {


    public void StartGameEmManutencao()
    {
        SceneManager.LoadScene("EmManutencao");
    }
    public void StartGameMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void StartGameEmManutencaoInicio()
    {
        SceneManager.LoadScene("EmManutencaoInicio");
    }


}