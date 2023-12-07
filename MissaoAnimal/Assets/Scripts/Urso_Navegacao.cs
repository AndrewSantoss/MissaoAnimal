using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Urso_Navegacao : MonoBehaviour {


    public void StartGameUrso()
    {
        SceneManager.LoadScene("TelaUrso");
    }
    public void StartGameMenu()
    {
        SceneManager.LoadScene("Menu");
    }


}