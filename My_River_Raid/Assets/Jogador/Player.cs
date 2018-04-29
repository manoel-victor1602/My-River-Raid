using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public Animator animador;

    // Use this for initialization
    void Start()
    {
        animador = GetComponent<Animator>();
        animador.SetBool("voando_esquerda", false);
        animador.SetBool("voando_direita", false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(animador.GetBool("voando_esquerda"));
        while(Input.GetKey(KeyCode.LeftArrow)){
            voandoEsquerda();
        }
        while(Input.GetKey(KeyCode.RightArrow)){
            voandoDireita();
        }
        
    }
    void parado()
    {
        animador.SetBool("voando_esquerda", false);
        animador.SetBool("voando_direita", false);
    }
    void voandoEsquerda()
    {
        animador.SetBool("voando_esquerda", true);
        animador.SetBool("voando_direita", false);
    }
    void voandoDireita()
    {
        animador.SetBool("voando_direita", true);
        animador.SetBool("voando_esquerda", false);
    }
}