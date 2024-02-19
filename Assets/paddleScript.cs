using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour
{
    public float speed = 5f;
    public float maxY = 2.29f;
    public float minY = -2.4f;

    // Update is called once per frame
    void Update()
    {
        // Move paddle up if W key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
            // Limit paddle movement to maxY
            if (transform.position.y >= maxY)
            {
                transform.position = new Vector3(transform.position.x, maxY, 0f);
            }
        }
        // Move paddle down if S key is pressed
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
            // Limit paddle movement to minY
            if (transform.position.y <= minY)
            {
                transform.position = new Vector3(transform.position.x, minY, 0f);
            }
        }
    }


    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.02f, 0f);
            if(transform.position.y >= 2.29f)
            {
                var x = transform.position.x;
                transform.transform.position = new Vector3(x,2.29f, 0f);
                
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.02f, 0f);
            if (transform.position.y <= -2.4f)
            {
                var x = transform.position.x;
                transform.transform.position = new Vector3(x, -2.4f, 0f);
                
            }
        }
    }

        //Debug.Log(transform.position.y);
        
*/
}

