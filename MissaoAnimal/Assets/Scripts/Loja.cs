using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Loja : MonoBehaviour
{
    //Pegando os pontos salvos
    private int pontosInt;
    public Text pontos;

    //botoes
    public GameObject btnT;
    public GameObject btnC;
    public GameObject btnO;
    public GameObject btnU;

    //trofeu
    public GameObject trofeuT;
    public GameObject trofeuC;
    public GameObject trofeuO;
    public GameObject trofeuU;

    //trofeu
    public GameObject sombraT;
    public GameObject sombraC;
    public GameObject sombraO;
    public GameObject sombraU;

    //popup
    public GameObject popup;

    //auxiliar para chegar o trofeu
    private int auxT;
    private int auxC;
    private int auxO;
    private int auxU;

    // Start is called before the first frame update
    void Start()
    {
        //Mostrando os pontos
        //PlayerPrefs.SetInt("pontos", 500);
        pontosInt = PlayerPrefs.GetInt("pontos");
        
    }

    // Update is called once per frame
    void Update()
    {
        pontos.text = pontosInt.ToString();
        ChecarTrofeu();
    }

    //funcao para fechar o popup
    public void FecharPop()
    {
        popup.SetActive(false);
    }

    //funcao para identificar a compra
    public void CompraT()
    {
        if(pontosInt >= 50)
        {
            pontosInt = pontosInt - 50;
            PlayerPrefs.SetInt("pontos", pontosInt);
            btnT.SetActive(false);
            sombraT.SetActive(false);
            trofeuT.SetActive(true);
            PlayerPrefs.SetInt("trofeuT", 1);
        }
        else
        {
            popup.SetActive(true);
        }
    }

    public void CompraC()
    {
        if(pontosInt >= 50)
        {
            pontosInt = pontosInt - 50;
            PlayerPrefs.SetInt("pontos", pontosInt);
            btnC.SetActive(false);
            sombraC.SetActive(false);
            trofeuC.SetActive(true);
            PlayerPrefs.SetInt("trofeuC", 1);
        }
        else
        {
            popup.SetActive(true);
        }
    }

    public void CompraO()
    {
        if(pontosInt >= 50)
        {
            pontosInt = pontosInt - 50;
            PlayerPrefs.SetInt("pontos", pontosInt);
            btnO.SetActive(false);
            sombraO.SetActive(false);
            trofeuO.SetActive(true);
            PlayerPrefs.SetInt("trofeuO", 1);
        }
        else
        {
            popup.SetActive(true);
        }
    }
    
    public void CompraU()
    {
        if(pontosInt >= 50)
        {
            pontosInt = pontosInt - 50;
            PlayerPrefs.SetInt("pontos", pontosInt);
            btnU.SetActive(false);
            sombraU.SetActive(false);
            trofeuU.SetActive(true);
            PlayerPrefs.SetInt("trofeuU", 1);
        }
        else
        {
            popup.SetActive(true);
        }
    }

    private void ChecarTrofeu ()
    {
        //trofeu tartaruga
        auxT = PlayerPrefs.GetInt("trofeuT");
        if(auxT == 1)
        {
            btnT.SetActive(false);
            sombraT.SetActive(false);
            trofeuT.SetActive(true);
        }
        else
        {
            btnT.SetActive(true);
            sombraT.SetActive(true);
            trofeuT.SetActive(false);
        }

        //trofeu cachorro
        auxC = PlayerPrefs.GetInt("trofeuC");
        if(auxC == 1)
        {
            btnC.SetActive(false);
            sombraC.SetActive(false);
            trofeuC.SetActive(true);
        }
        else
        {
            btnC.SetActive(true);
            sombraC.SetActive(true);
            trofeuC.SetActive(false);
        }

        //trofeu onca
        auxO = PlayerPrefs.GetInt("trofeuO");
        if(auxO == 1)
        {
            btnO.SetActive(false);
            sombraO.SetActive(false);
            trofeuO.SetActive(true);
        }
        else
        {
            btnO.SetActive(true);
            sombraO.SetActive(true);
            trofeuO.SetActive(false);
        }

        //trofeu urso
        auxU = PlayerPrefs.GetInt("trofeuU");
        if(auxU == 1)
        {
            btnU.SetActive(false);
            sombraU.SetActive(false);
            trofeuU.SetActive(true);
        }
        else
        {
            btnU.SetActive(true);
            sombraU.SetActive(true);
            trofeuU.SetActive(false);
        }
    }
}
