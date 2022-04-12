using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    private PlayerController playerCtrl;


    private Rigidbody rbPlayer;
    public float gravityModifer;
    public float jumpForce;
    private bool onGround = true;
    public bool gameOver = false;


    public ParticleSystem smokeSystem;


    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource asPlayer;
    
    

    public float horizontalInput;
    public float verticalInput;


    // Start is called before the first frame update
    void Start()
    {

        rbPlayer = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifer;

        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();

        asPlayer = GetComponent<AudioSource>();
        

    }




    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            smokeSystem.Play();
            asPlayer.PlayOneShot(crashSound, 5.0f);
        }
        
    }



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        bool spaceDown = Input.GetKeyDown(KeyCode.Space);
        if (spaceDown && onGround && !gameOver)
        {
            rbPlayer.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
            asPlayer.PlayOneShot(jumpSound, 3.0f);

        }
        if (playerCtrl.gameOver == false)
        







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




     

