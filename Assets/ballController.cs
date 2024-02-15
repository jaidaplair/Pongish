using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb;//get a reference to our rb        
        rb = GetComponent<Rigidbody2D>();//get a reference to our rb        

        //set velocity
        rb.velocity = new Vector3(Random.Range(-700f, 700f), Random.Range(-700f, 700f)) * Time.deltaTime;

        AudioSource audioSource;//reference to audio source
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //create popping noise whenever person presses space bar
        {
            AudioSource audioSource;//reference to audio source
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Ouch! That hurt man!");
        AudioSource audioSource;//reference to audio source
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }
}
