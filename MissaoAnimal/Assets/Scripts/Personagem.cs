using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{
    //movimentar o personagem
    public float velocidade;
    //fazer o personagem pular
    public float forcaPulo;
    //pegar o companente
    public Rigidbody2D personagemRigi;
    //indicar se o personagem esta pisando no chao
    public bool pisandoChao;
    //atualizar ao pegar o item/pontos
    public Text coracaoText;
    //contar os itens pegos
    private int coracao;
    //auxiliar de pontos
    private int coracaoPontos;

    //fazendo a vida do personagem
    private int vida;
    private int vidaCheia = 3;

    [SerializeField] Image vidaJogo3;
    [SerializeField] Image semVidaJogo3;

    [SerializeField] Image vidaJogo2;
    [SerializeField] Image semVidaJogo2;

    [SerializeField] Image vidaJogo1;
    [SerializeField] Image semVidaJogo1;

    //popup
    public GameObject popupMorte;
    public GameObject popupPause;
    public GameObject popupFim;

    //teste morte e pause
    public bool vivo;
    public bool pause;
    public bool fim;

    //botao pause
    public GameObject btnPause;

    // Start is called before the first frame update
    void Start()
    {
        personagemRigi = GetComponent<Rigidbody2D>();
        coracao = 0;
        vida = vidaCheia;
        popupMorte.SetActive(false);
        popupPause.SetActive(false);
        vivo = true;
        pause = false;
        fim = false;

        Debug.Log(PlayerPrefs.GetInt("pontos"));
        coracaoPontos = PlayerPrefs.GetInt("pontos");
    }

    // Update is called once per frame
    void Update()
    {
        VeriPopup();
        if(vivo == true && pause == false && fim == false)
        {
            Mover();
            if(Input.GetButtonDown("Jump") == true)
            {
                Pular();
            }
            AtualizarValor();
        }
    }

    //funcao de movimentar o personagem
    public void Mover()
    {
        Vector3 movimentos = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimentos * Time.deltaTime * velocidade;

    }

    //funcao para fazer o personagem pular
    public void Pular()
    {
        if(pisandoChao == true && vivo == true && pause == false && fim == false)
        {
            personagemRigi.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
            pisandoChao = false;
        }
    }

    //funcao para verificar se o personagem esta pisando no chao
    private void OnCollisionEnter2D(Collision2D colli)
    {
        if(colli.gameObject.CompareTag("chao"))
        {
            pisandoChao = true;
        }
    }
    
    //identificar que passou pelo Item/local
    private void OnTriggerEnter2D(Collider2D colli)
    {
        if(colli.gameObject.CompareTag("itens"))
        {
            coracao = coracao + 1;
            Destroy(colli.gameObject);
        }
        if(colli.gameObject.CompareTag("morte"))
        {
            Morte();
            //chama a posicao inicial
            personagemRigi.transform.position = new Vector2(-12.46f, -2.3f);
        }
        if(colli.gameObject.CompareTag("fim"))
        {
            popupFim.SetActive(true);
            btnPause.SetActive(false);
            fim = true;
            //Salvando os pontos pegos na tela atual e nas outras que ja foi jogada
            coracaoPontos = coracaoPontos + coracao;
            //salvar pontos
            PlayerPrefs.SetInt("pontos", coracaoPontos);
        }
    }
    
    //atualizar o valor ao passar pelo item
    private void AtualizarValor()
    {
        coracaoText.text = coracao.ToString();
    }

    //funcao para verificar o dano e informar o game over
    private void Morte()
    {
        vida = vida - 1;

        if(vida == 2)
        {
            vidaJogo3.enabled = false;
            semVidaJogo3.enabled = true;
        }
        else if(vida == 1)
        {
            vidaJogo2.enabled = false;
            semVidaJogo2.enabled = true;
        }
        else if(vida <= 0)
        {
            vidaJogo1.enabled = false;
            semVidaJogo1.enabled = true;
            popupMorte.SetActive(true);
            vivo = false;
            btnPause.SetActive(false);
        }
    }

    private void VeriPopup()
    {
        if(popupPause.activeSelf == true)
        {
            pause = true;
        }
        else
        {
            pause = false;
        }
    }

}
