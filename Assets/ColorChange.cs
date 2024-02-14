using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{
   // void Start()
  //  {
       // GetComponent<SpriteRenderer>().color =originalColor;
       

    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            //GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().material.color = Color.red;
        }
       
            //GetComponent<SpriteRenderer>().material.color = new Color(255f, 255f, 255f, 255f);
            
        
        //GetComponent<SpriteRenderer>().material.color = Color.red;
       /* if (collision.gameObject.tag != "Target")
        {
            //GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().material.color = new Color(255f, 255f,255f,255f);
        }*/
    }

}
