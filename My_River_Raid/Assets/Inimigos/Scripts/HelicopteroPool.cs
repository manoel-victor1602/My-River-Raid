using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopteroPool : MonoBehaviour {

    public int helicopteroPoolSize = 5;
    public GameObject helicopteroPrefab;
    public float freqSpawn = 2f;
    public float helicopteroMin = -5f;
    public float helicopteroMax = 5f;

    private GameObject[] helicopteros;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float helicopteroTimeSpawn;
    private int currentHelicoptero = 0;
    private float spawnXPosition;

    // Use this for initialization
    void Start () {
        helicopteros = new GameObject[helicopteroPoolSize];

        for(int i = 0; i < helicopteroPoolSize; i++)
        {
            helicopteros[i] = GameObject.Instantiate(helicopteroPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        helicopteroTimeSpawn += Time.deltaTime;
        if (Player.instance.vivo == true && helicopteroTimeSpawn >= freqSpawn)
        {
            helicopteroTimeSpawn = 0;
            float spawnYPosition = Random.Range(helicopteroMin, helicopteroMax);
            float spawnXPosition = Random.Range(1f, 5f);
            helicopteros[currentHelicoptero].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentHelicoptero++;
            if(currentHelicoptero >= helicopteroPoolSize)
            {
                currentHelicoptero = 0;
            }
        }
	}
}
