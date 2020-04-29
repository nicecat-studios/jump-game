using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using UnityEngine;

public class legacy_CameraController : MonoBehaviour
{
    GameObject player;
    GameObject[] cameras;
    int camIterator;
    float storedPosition;

    //Every time player height changes by 10, adjust depending on whether it was decreased or increased
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        cameras = GameObject.FindGameObjectsWithTag("MainCamera");
        foreach(GameObject g in cameras)
        {
            if(g.name == "Cam0") { continue; }
            UnityEngine.Debug.Log(g);
            g.SetActive(false);
        }
        camIterator = 0;
        storedPosition = player.transform.position.y;
        UnityEngine.Debug.Log(storedPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.y - storedPosition) > 10)
        {
            storedPosition += 9;
            camIterator += 1;
            cameras[camIterator].SetActive(true);
            cameras[camIterator - 1].SetActive(false);
        }

        if ((storedPosition - player.transform.position.y) > 2)
        {
            storedPosition -= 9;
            camIterator -= 1;
            cameras[camIterator].SetActive(true);
            cameras[camIterator + 1].SetActive(false);
        }
    }
}
