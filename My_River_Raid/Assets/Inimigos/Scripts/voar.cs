using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voar : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float velocidade = 2f;
    private int direcao = 0;

    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(velocidade, -5f);
    }
	
	// Update is called once per frame
	void Update () {
        rb2d.velocity = new Vector2(velocidade, -5f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mudaDirecao();
        transform.eulerAngles = new Vector2(0, direcao);
        velocidade = -velocidade;
    }

    void mudaDirecao()
    {
        if (direcao == 0)
            direcao = 180;
        else
            direcao = 0;
    }
}
