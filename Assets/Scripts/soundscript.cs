using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscript : MonoBehaviour
{   //sound that will play when an obj enters this trigger
    public AudioClip triggerSound;
    //audio source taht will play that sound
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(triggerSound);
    }

}
