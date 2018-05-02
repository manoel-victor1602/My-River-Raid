using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public int objectPoolSize = 3;
    public GameObject objectPrefab;
    public float freqSpawn = 3f;
    public float objectMin;
    public float objectMax;
    public float minSpawnXPosition;
    public float maxSpawnXPosition;

    private GameObject[] objects;
    private Vector2 objectPoolPosition = new Vector2(-5f, -25f);
    private float objectTimeSpawn;
    private int currentObject = 0;
    private float spawnXPosition;

    // Use this for initialization
    void Start()
    {
        objects = new GameObject[objectPoolSize];

        for (int i = 0; i < objectPoolSize; i++)
        {
            objects[i] = GameObject.Instantiate(objectPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        objectTimeSpawn += Time.deltaTime;
        if (Player.instance.vivo == true && objectTimeSpawn >= freqSpawn)
        {
            objectTimeSpawn = 0;
            float spawnYPosition = Random.Range(objectMin, objectMax);
            float spawnXPosition = Random.Range(minSpawnXPosition, maxSpawnXPosition);
            objects[currentObject].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentObject++;
            if (currentObject >= objectPoolSize)
            {
                currentObject = 0;
            }
        }
    }
}
