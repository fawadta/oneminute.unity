using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        //Debug.Log("Hello! Visual studio linked successfully");
    }
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
}
