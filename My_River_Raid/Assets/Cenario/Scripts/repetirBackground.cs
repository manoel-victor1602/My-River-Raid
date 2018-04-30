using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repetirBackground : MonoBehaviour {

    private float backgroundLength;

	// Use this for initialization
	void Start () {
        backgroundLength = 68f;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -backgroundLength)
        {
            ReposicionarBackground();
        }
	}
    private void ReposicionarBackground()
    {
        Vector2 terraOffset = new Vector2(0, backgroundLength * 2f);
        transform.position = (Vector2)transform.position + terraOffset;
    }
}
