using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Button button;
    private GameObject player;
    private Rigidbody2D rbody;
    private GameObject camera;

    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera");
        player = GameObject.FindWithTag("Player");
        rbody = player.GetComponent<Rigidbody2D>();
        button.onClick.AddListener(Respawn);
    }


    void Respawn()
    {
        rbody.velocity = new Vector3(0, 0, 0);
        player.transform.position = new Vector3(-60.5f, 9.3f, -0.16f);
        camera.transform.position = new Vector3(-51.7597f, 14.07621f, -32.28906f);
        //CameraController.storedPosition = 0f;
    }
}
