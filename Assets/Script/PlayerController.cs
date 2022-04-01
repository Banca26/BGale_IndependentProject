using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    public float turnSpeed = 20.0f;

    private Rigidbody rbPlayer;
    

    public float horizontalInput;
    public float verticalInput;


    // Start is called before the first frame update
    void Start()
    {

        rbPlayer = GetComponent<Rigidbody>();
        

    }




    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        bool spaceDown = Input.GetKeyDown(KeyCode.Space);
        if(spaceDown)
        {
            rbPlayer.AddForce(Vector3.up * 8, ForceMode.Impulse);
        }


        Debug.Log(Time.deltaTime);

            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            



            if (transform.position.x > 7)
            {
                transform.position = new Vector3(7, transform.position.y, transform.position.z);
            }

            if (transform.position.x < -7)
            {
                transform.position = new Vector3(-7, transform.position.y, transform.position.z);
            }
            if (transform.position.z > 45)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 45);
            }

            if (transform.position.z < -48)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -48);
            }

            
            }

        }




     

