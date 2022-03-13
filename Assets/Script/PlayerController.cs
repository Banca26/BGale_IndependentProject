using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    
    
    

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
         
    }
   
 
        
   
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (transform.position.x > 3)
        {
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -3)
        {
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 45)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 45);
        }

        if (transform.position.z < - 48)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        }
    }
}
