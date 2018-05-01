using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombustivelPool : MonoBehaviour
{

    public int combustivelPoolSize = 5;
    public GameObject combustivelPrefab;
    public float freqSpawn = 3f;
    public float combustivelMin = -5f;
    public float combustivelMax = 5f;

    private GameObject[] combustiveis;
    private Vector2 objectPoolPosition = new Vector2(-5f, -25f);
    private float combustivelTimeSpawn;
    private int currentCombustivel = 0;
    private float spawnXPosition;

    // Use this for initialization
    void Start()
    {
        combustiveis = new GameObject[combustivelPoolSize];

        for (int i = 0; i < combustivelPoolSize; i++)
        {
            combustiveis[i] = GameObject.Instantiate(combustivelPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        combustivelTimeSpawn += Time.deltaTime;
        if (Player.instance.vivo == true && combustivelTimeSpawn >= freqSpawn)
        {
            combustivelTimeSpawn = 0;
            float spawnYPosition = Random.Range(combustivelMin, combustivelMax);
            float spawnXPosition = Random.Range(-6f, 4f);
            combustiveis[currentCombustivel].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentCombustivel++;
            if (currentCombustivel >= combustivelPoolSize)
            {
                currentCombustivel = 0;
            }
        }
    }
}
