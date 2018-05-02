using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combustivel : MonoBehaviour {

    public Animator animador;

    public bool vivo = true;
    public int pontuacao;

    // Use this for initialization
    void Start () {
        animador = GetComponent<Animator>();
        animador.SetBool("vivo", true);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y + 1 < Player.instance.transform.position.y)
        {
            vivo = true;
            animador.SetBool("vivo", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiro")
        {
            vivo = false;
            animador.SetBool("vivo", false);
            Game_Control.instance.score += pontuacao;
            reposiciona.instance.rb2d.position = new Vector2(reposiciona.instance.rb2d.position.x + 5 * 0.145f, reposiciona.instance.rb2d.position.y);
        }
    }
}
