using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopsMeP : MonoBehaviour
{
    public GameObject popupPause;
    public Personagem persona;

    //Start is called before the first frame update
    void Start()
    {
        persona = GetComponent<Personagem>();
    }
    
    public void RecaregarTela()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AbrirPopupPause()
    {
        popupPause.SetActive(true);
    }

    public void Continuar()
    {
        popupPause.SetActive(false);
    }

    public void Sair()
    {
        SceneManager.LoadScene("NavegacaoTelas");
    }
}