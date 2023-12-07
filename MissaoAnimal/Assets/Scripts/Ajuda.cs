using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ajuda : MonoBehaviour {


    public void StartGameNavegacao()
    {
        SceneManager.LoadScene("NavegacaoTelas");
    }
    public void StartGameMenus()
    {
        SceneManager.LoadScene("Menu");
    }


}
