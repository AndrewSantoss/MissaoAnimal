using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacaoTelas : MonoBehaviour {

    public void TelaUrso()
    {
        SceneManager.LoadScene("TelaUrso");
    }
    public void TelaTartaruga()
    {
        SceneManager.LoadScene("TelaTartaruga");
    }
    public void TelaOrca()
    {
        SceneManager.LoadScene("TelaOnca");
    }
    public void TelaCachorro()
    {
        SceneManager.LoadScene("TelaCachorro");
    }


    public void Ajuda()
    {
        SceneManager.LoadScene("Ajuda");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Navegacao()
    {
        SceneManager.LoadScene("NavegacaoTelas");
    }
    public void Manutencao()
    {
        SceneManager.LoadScene("EmManutencaoInicio");
    }
    public void AjudaNavegacao()
    {
        SceneManager.LoadScene("AjudaNavegacao");
    }
    public void Loja()
    {
        SceneManager.LoadScene("Loja");
    }
    public void InfoLoja()
    {
        SceneManager.LoadScene("InfoLoja");
    }
    public void ComoJogar()
    {
        SceneManager.LoadScene("ComoJogar");
    }
}