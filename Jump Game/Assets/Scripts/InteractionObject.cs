using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public bool talks;
    public string message;
    public void Talk()
    {
        Debug.Log(message);
    }
  
   
}
