using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2f;//inside class, outside any function

    
    // Update is called once per frame
    void Update()
    {
        //Store current position value of the transform of the object this component is in
        // Stored current position of the object
        Vector3 temp=this.transform.position;

         temp.x = temp.x + speed * Time.deltaTime;//temp.x += speed; add speed to current x value of temp

        this.transform.position = temp;//Assign temp as new pos of obj; teleporting the obj in small amounts quickly

    }
}
