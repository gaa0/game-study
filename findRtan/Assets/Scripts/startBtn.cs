using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void startGame()
{
    SceneManager.LoadScene("MainScene");
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
