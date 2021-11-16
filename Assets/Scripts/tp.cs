using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    //Jimmy Vegas
    
    public Transform teleportTarget;
    public GameObject thePlayer;

  void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;

    }
}
