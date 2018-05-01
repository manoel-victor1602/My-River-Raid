using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    public Animator animador;

    public bool vivo = true;

    // Use this for initialization
    void Start () {
        animador = GetComponent<Animator>();
        animador.SetBool("vivo", true);
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y < Player.instance.transform.position.y)
        {
            vivo = true;
            animador.SetBool("vivo", true);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "tiro" || collision.gameObject.tag == "Player")
        {
            vivo = false;
            animador.SetBool("vivo", false);
        }
        
        
    }

    IEnumerator timer()
    { 
        yield return new WaitForSeconds(2.0f);
    }
}