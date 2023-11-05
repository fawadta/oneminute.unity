using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject playerPrefab;

    // (x, z): 5 to -5: (5, 5), (-5, 5), (5, -5), (-5, -5)
    public float xMin = -5, xMax = 5;
    //float yMin = -5, yMax = 5;
    public float zMin = -5, zMax = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn(playerPrefab);
        SpawnRandomly(playerPrefab);
    }
    private void Spawn(GameObject gameObject)
    {
        Instantiate(gameObject, playerPrefab.transform.position, gameObject.transform.rotation);
    }
    private void SpawnRandomly(GameObject gameObject)
    {
        float randomX = Random.Range(xMin, xMax);
        //float randomY = Random.Range(yMin, yMax);
        float randomZ = Random.Range(zMin, zMax);
        Instantiate(gameObject, new Vector3(randomX, gameObject.transform.position.y, randomZ), gameObject.transform.rotation);
    }
}
