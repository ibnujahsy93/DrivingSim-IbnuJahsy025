using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
    
{
    
    private float speed = 10.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private float maju;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        maju = Input.GetAxis("Submit");


        // Maju Berdasarkan Vertical Input(Keyboard W,S)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * maju);


        // Rotasi Berdasarkan Horizontal Input(Keyboard A,D)
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * forwardInput * Time.deltaTime);

        

    }
}
