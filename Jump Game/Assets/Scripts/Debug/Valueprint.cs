using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Valueprint : MonoBehaviour
{
    public Text text;
    public PlayerController playerController;
    double charger;
    
    // Start is called before the first frame update
    void Start()
    {
        charger = playerController.charger;
    }

    // Update is called once per frame
    void Update()
    {

        charger = System.Math.Round(playerController.charger,1);
        text.text = charger.ToString();
    }
}
