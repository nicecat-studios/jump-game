using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    public GameObject camera;
    public static float storedPosition;

    //Every time player height changes by 10, adjust depending on whether it was decreased or increased
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camera = GameObject.FindWithTag("MainCamera");
        storedPosition = player.transform.position.y;
        UnityEngine.Debug.Log(storedPosition);
    }

    void Update()
    {
        if((player.transform.position.y - storedPosition) > 10)
        {
            storedPosition += 10;
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + 10, camera.transform.position.z);
        }

        if ((storedPosition - player.transform.position.y) > 2)
        {
            storedPosition -= 10;
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 10, camera.transform.position.z);
        }
    }
}
