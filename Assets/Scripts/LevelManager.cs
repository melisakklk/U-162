using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public void Awake()
    {
        Instance = this; 
    }


    void Start()
    {
        Debug.Log(transform.childCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelCleared()
    {
        if(transform.childCount == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
