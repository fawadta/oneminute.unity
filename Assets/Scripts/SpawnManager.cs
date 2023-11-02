using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, playerPrefab.transform.position, playerPrefab.transform.rotation);
    }
}
