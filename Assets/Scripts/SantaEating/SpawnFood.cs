using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public float spawnTime = 1.5f;
    public GameObject[] Food;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("SpawnFod", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void SpawnFod()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, Food.Length);
        //for (var i = 1; i <= Food.Length; i++)
        for (var i = 1; i <= 1; i++)
        {
            Instantiate(Food[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);

        }
    }
}
