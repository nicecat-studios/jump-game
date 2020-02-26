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
        StartCoroutine(ChangeSceneToGame());
    }

    private IEnumerator ChangeSceneToGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
    }
}
