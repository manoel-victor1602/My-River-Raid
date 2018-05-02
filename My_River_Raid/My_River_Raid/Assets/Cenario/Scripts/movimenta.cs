﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimenta : MonoBehaviour {

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start() {        
            rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(0, -3f);
	}
	
	// Update is called once per frame
	void Update () {
        if (!Player.instance.vivo)
            rb2d.velocity = Vector2.zero;
	}
}