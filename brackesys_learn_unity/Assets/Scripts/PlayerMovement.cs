using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    //to control on phone
    public float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, world!");

        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500); //AddForce fonksiyonu çağrıldı
        ScreenWidth = Screen.width;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //time deltatime to run every comp as same
        //Debug.Log(Time.deltaTime);


        /* ------------------------------------------------------------------------------------------*/


        //to control on phone
        int i = 0;
        //loop over every touch found
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //move left
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            ++i;
        }


        /* ------------------------------------------------------------------------------------------*/


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -(sidewaysForce * Time.deltaTime), ForceMode.VelocityChange);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }

        //aşağıya gidince oyun biter

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}


/*
 

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start(){
        //Debug.Log("Hello, world!");

        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500); //AddForce fonksiyonu çağrıldı
    }

    // Update is called once per frame
    void FixedUpdate(){
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //time deltatime to run every comp as same
        //Debug.Log(Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w")){
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("s")){
            rb.AddForce(0, 0, -(sidewaysForce * Time.deltaTime), ForceMode.VelocityChange);
        }
        if (Input.GetKey("space")){
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }

        //aşağıya gidince oyun biter
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
 
 */