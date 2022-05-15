using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ball"))
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
