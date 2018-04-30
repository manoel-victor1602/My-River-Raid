using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {

    private Vector2 velocidade = new Vector2(0, 15);
    private Rigidbody2D rbTiro;

	// Use this for initialization
	void Start () {
        rbTiro = GetComponent<Rigidbody2D>();
        rbTiro.velocity = velocidade;
        Destroy(gameObject, 3f);
	}
}
