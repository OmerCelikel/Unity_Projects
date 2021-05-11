using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{


    public Rigidbody rb;

    public float forwardForce = 200f;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Hello, world!");

        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500); //AddForce fonksiyonu çağrıldı
    }

    // Update is called once per frame
    void FixedUpdate(){
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //time deltatime to run every comp as same
        Debug.Log(Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -(500 * Time.deltaTime));
        }
    }
}
