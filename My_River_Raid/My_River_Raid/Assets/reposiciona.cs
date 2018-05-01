using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reposiciona : MonoBehaviour {

    public static reposiciona instance;

    public Rigidbody2D rb2d;
    public float escala;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!Player.instance.vivo)
            rb2d.velocity = Vector2.zero;

        desabastecer();
        
    }
    void desabastecer()
    {
        rb2d.position = new Vector2(rb2d.position.x - 0.145f * Time.deltaTime, rb2d.position.y);
    }
}
