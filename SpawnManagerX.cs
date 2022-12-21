using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnMostWait = 5.0f;
    private float spawnLeastWait = 3.0f;
    public int startWait;
    private float spawnWait;
    public bool stop;

    int randBallPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
    }
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    // Spawn random ball at random x position at top of play area
    IEnumerator waitSpawner() 
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            randBallPrefabs = Random.Range(0, 3);
            //Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randBallPrefabs], spawnPos, ballPrefabs[randBallPrefabs].transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }

}
