using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public Animator animador;

    private float freqTiro = 0.75f;
    private float tiroCooldown = 0f;

    private Vector2 velocidade = new Vector2(3, 0);
    private Rigidbody2D rbJogador;

    public Transform local_tiro;
    public GameObject tiro;

    public static Player instance;

    public bool vivo = true;
    public int combustivel = 30;

    public float minXcombustivel = -302.1f;
    public float maxXcombustivel = -297.75f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        animador = GetComponent<Animator>();
        rbJogador = GetComponent<Rigidbody2D>();
        animador.SetBool("voando_esquerda", false);
        animador.SetBool("voando_direita", false);
        animador.SetBool("vivo", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(vivo == true)
        {
            if (tiroCooldown > 0)
                tiroCooldown -= Time.deltaTime;

            gatilho();
            movimentar();
            desabastecer();
        }           
    }
    void desabastecer()
    {
        if(vivo == false)
        {
            animador.SetBool("vivo", false);
        }
    }
    void movimentar()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            voandoEsquerda();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            voandoDireita();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            parado();
        }
    }

    private void gatilho()
    {
        if (Input.GetKey("space"))
        {
            atirar();
            tiroCooldown = freqTiro;
        }
    }

    private void atirar()
    {
        if(tiroCooldown <= 0f)
        {
            if(tiro != null)
            {
                var cloneTiro = Instantiate(tiro, local_tiro.position, Quaternion.identity) as GameObject;
                cloneTiro.transform.localScale = this.transform.localScale;
            }
        }
    }

    private void parado()
    {
        animador.SetBool("voando_esquerda", false);
        animador.SetBool("voando_direita", false);
        rbJogador.velocity = Vector2.zero;
    }
    private void voandoEsquerda()
    {
        animador.SetBool("voando_esquerda", true);
        animador.SetBool("voando_direita", false);
        rbJogador.velocity = -velocidade;
    }
    private void voandoDireita()
    {
        animador.SetBool("voando_direita", true);
        animador.SetBool("voando_esquerda", false);
        rbJogador.velocity = velocidade;
    }

    private void OnCollisionEnter2D()
    {
        vivo = false;
        animador.SetBool("vivo", false);
    }
}