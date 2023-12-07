using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMTarta : MonoBehaviour
{
    
    private int testeDirecao;
    public float velocidadeToque;
    private SpriteRenderer sprit;
    private Animator anima;
    private Tartaruga perso;

    // Start is called before the first frame update
    void Start()
    {
        sprit = GetComponent<SpriteRenderer>();
        anima = GetComponent<Animator>();
        perso = GetComponent<Tartaruga>();
    }

    // Update is called once per frame
    void Update()
    {
        if(perso.vivo == true && perso.pause == false && perso.fim == false)
        {
            TestarDirecao();
            Flip(testeDirecao);
            TesteAnima();
        }
    }

    public void TochHorizontal(int direcao)
    {
        testeDirecao = direcao;
    }

    // verificar qual direcao esta sendo apertada
    void TestarDirecao()
    {
        if(testeDirecao != 0)
        {
            transform.Translate(velocidadeToque * Time.deltaTime * testeDirecao, 0, 0);
        }
    }

    // fazer o personagem virar conforme a direcao
    private void Flip(int testeDirecao)
    {
        if(testeDirecao < 0)
        {
            sprit.flipX = true;
        }
        else if(testeDirecao > 0)
        {
            sprit.flipX = false;
        }
    }

    // fazer o personagem ter animacao ao andar
    private void TesteAnima()
    {
        if(testeDirecao != 0)
        {
            anima.SetBool("TesBool", true);
        }
        else
        {
            anima.SetBool("TesBool", false);
        }
    }
}
