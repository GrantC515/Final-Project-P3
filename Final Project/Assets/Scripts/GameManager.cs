using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ToWin();
    }

    private void ToWin()
    {
        throw new NotImplementedException();
    }

    public void ToWin(Collider other)
    {
        if(other.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene("Win Scene");
        }
    }
}
