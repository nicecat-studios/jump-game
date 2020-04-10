using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public InteractionObject currentInterObjScript = null;
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Interact") && currentInterObj)
        {
            if (currentInterObjScript.talks)
            {
                currentInterObjScript.Talk();
            }

        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent <InteractionObject>  ();
        }
    }
}
