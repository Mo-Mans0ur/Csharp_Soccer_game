using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public static int currentLevel = 1;


    public static void LoadNextLevel()
    {
        currentLevel++;
        SceneManager.LoadScene("Level" + currentLevel);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
