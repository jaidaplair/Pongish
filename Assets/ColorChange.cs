using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{
    // void Start()
    //  {
    // GetComponent<SpriteRenderer>().color =originalColor;

    private Color originalColor;
    private SpriteRenderer spriteRenderer;

    //}
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            /*for (float i  = 0; i < 1000; i++)
            {
                GetComponent<SpriteRenderer>().material.color = Color.black;
                //StartCoroutine(RevertColorAfterDelay(1000f));
            }*/
            //GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            //GetComponent<SpriteRenderer>().material.color = Color.black;
            spriteRenderer.color = Color.green;
            //yield return new WaitForSeconds(2f);
            // Start the coroutine to revert the color after 1 second
            StartCoroutine(RevertColorAfterDelay(0.35f));

        }
     
    }

        private IEnumerator RevertColorAfterDelay(float delay)
        {
            // Wait for the specified delay
            yield return new WaitForSeconds(delay);
            // Revert the object's color back to its original color
            spriteRenderer.color = originalColor;
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
        //StartCoroutine(RevertColorAfterDelay(3));
            //Invoke(RevertColorAfterDelay, 3f);
            //yield return new WaitForSeconds(2f);
            if (collision.gameObject.tag == "Target")
            {
            
                //GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
                //GetComponent<SpriteRenderer>().material.color = Color.red;
                spriteRenderer.material.color = originalColor;
            }

        }
    /*private IEnumerator RevertColorAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);
        // Revert the object's color back to its original color
        spriteRenderer.color = originalColor;
    }*/
}
