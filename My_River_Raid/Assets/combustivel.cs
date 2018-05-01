using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combustivel : MonoBehaviour {

    public Animator animador;

    public bool vivo = true;

    // Use this for initialization
    void Start () {
        animador = GetComponent<Animator>();
        animador.SetBool("vivo", true);
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiro")
        {
            vivo = false;
            animador.SetBool("vivo", false);
        }
    }
}
