using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoroutine(ChangeSceneToGame(2));
        }
        
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartCoroutine(ChangeSceneToGame(0));
        }
    }

    private IEnumerator ChangeSceneToGame(int index)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(index);
    }
}
