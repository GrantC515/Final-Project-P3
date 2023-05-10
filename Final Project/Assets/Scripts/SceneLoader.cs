using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReplayFromGO()
    {
       SceneManager.LoadScene("Game");
    }

    public void ToMenuFromGO()
    {
        SceneManager.LoadScene("Intro Scene");
    }

    public void ReplayFromWin()
    {
        SceneManager.LoadScene("Game");
    }

    public void ToMenuFromWin()
    {
        SceneManager.LoadScene("Intro Scene");
    }
}
