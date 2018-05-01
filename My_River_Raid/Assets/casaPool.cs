using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casaPool : MonoBehaviour
{

    public int casaPoolSize = 4;
    public GameObject casaPrefab;
    public float freqSpawn = 2f;
    public float casaMin = -5f;
    public float casaMax = 5f;

    private GameObject[] casas;
    private Vector2 objectPoolPosition = new Vector2(-5f, -25f);
    private float casaTimeSpawn;
    private int currentCasa = 0;
    private float spawnXPosition;

    // Use this for initialization
    void Start()
    {
        casas = new GameObject[casaPoolSize];

        for (int i = 0; i < casaPoolSize; i++)
        {
            casas[i] = GameObject.Instantiate(casaPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        casaTimeSpawn += Time.deltaTime;
        if (Player.instance.vivo == true && casaTimeSpawn >= freqSpawn)
        {
            casaTimeSpawn = 0;
            float spawnYPosition = Random.Range(casaMin,casaMax);
            float spawnXPosition = Random.Range(-10f, -7f);
            casas[currentCasa].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentCasa++;
            if (currentCasa >= casaPoolSize)
            {
                currentCasa = 0;
            }
        }
    }
}
