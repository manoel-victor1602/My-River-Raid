using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Control : MonoBehaviour {

    public static Game_Control instance;
    public Text scoreText;

    public int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pontuar();
        destruirAviaoFaltaCombustivel();
	}

    void pontuar()
    {
        scoreText.text = score.ToString();
    }
    void destruirAviaoFaltaCombustivel()
    {
        if (reposiciona.instance.rb2d.position.x <= -2.5f)
        {
            Player.instance.vivo = false;
            Player.instance.animador.SetBool("vivo", false);
        }
    }
}
