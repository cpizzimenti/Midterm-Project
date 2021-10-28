using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PArticleScript : MonoBehaviour
{

    public GameObject triggerParticle;
    public GameObject collisionParticle;
    public static int score;

    private void Start()
    {
        score = 0;
    }

    //gets exectued when somthing enters this trigger or when this object enteres a trigger
    private void OnTriggerEnter(Collider other)
    {
        if(triggerParticle!=null)
        {
            //te trigger particle will be spawned @ location of this object
            // w same rotation as this object
            Instantiate(triggerParticle,this.transform.position, this.transform.rotation);
        }
    }


    //gets executed when somthing collides w this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);

            if (this.tag == "Green")
            {
                score += 5;
            }

            if (this.tag == "Orange")
            {
                score += 10;
            }

            if (this.gameObject.tag == "Red")
            {
                score += 20;
            }
        }
    }


}
