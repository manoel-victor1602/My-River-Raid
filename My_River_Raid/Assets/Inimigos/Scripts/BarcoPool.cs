using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarcoPool : MonoBehaviour {

    public int barcoPoolSize = 5;
    public GameObject barcoPrefab;
    public float freqSpawn = 3f;
    public float barcoMin = -5f;
    public float barcoMax = 5f;

    private GameObject[] barcos;
    private Vector2 objectPoolPosition = new Vector2(-5f, -25f);
    private float barcoTimeSpawn;
    private int currentBarco = 0;
    private float spawnXPosition;

    // Use this for initialization
    void Start () {
        barcos = new GameObject[barcoPoolSize];

        for (int i = 0; i < barcoPoolSize; i++)
        {
            barcos[i] = GameObject.Instantiate(barcoPrefab, objectPoolPosition, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        barcoTimeSpawn += Time.deltaTime;
        if (Player.instance.vivo == true && barcoTimeSpawn >= freqSpawn)
        {
            barcoTimeSpawn = 0;
            float spawnYPosition = Random.Range(barcoMin, barcoMax);
            float spawnXPosition = Random.Range(1f, 5f);
            barcos[currentBarco].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentBarco++;
            if (currentBarco >= barcoPoolSize)
            {
                currentBarco = 0;
            }
        }
    }
}
