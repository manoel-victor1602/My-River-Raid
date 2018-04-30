using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Control : MonoBehaviour {

    public Game_Control instance;

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
		
	}
}
