using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondPaddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0.02f, 0f);
            if (transform.position.y >= 2.29f)
            {
                var x = transform.position.x;
                transform.transform.position = new Vector3(x, 2.29f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.02f, 0f);
            if (transform.position.y <= -2.4f)
            {
                var x = transform.position.x;
                transform.transform.position = new Vector3(x, -2.4f, 0f);
            }
        }
    }
}