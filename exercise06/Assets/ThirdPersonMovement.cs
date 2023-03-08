using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;

    public GameManager gm;
    public float moveSpeed;
    public float rotateSpeed;
   // public GameManager gmo;


    //public float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        //GameManager gm = gmo.GetComponent<GameManager>();
       // gm.SetTimerText();



    }

    // Update is called once per frame
    void Update()
    {

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");


    
        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);

        

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);


        if (Input.GetKey(KeyCode.W))
        {
            //gameObject.transform.Translate(gameObject.transform.forward*speed);
            gameObject.transform.Rotate(rotateSpeed * Time.deltaTime * -1, 0, 0, Space.Self);
            moveSpeed -= .01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //gameObject.transform.Translate(gameObject.transform.forward*speed);
            gameObject.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0, Space.Self);
            moveSpeed += .1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //gameObject.transform.Translate(gameObject.transform.forward*speed);
            gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * -1, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.Translate(gameObject.transform.forward*speed);
            gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);

        }

        //public float speed = 6f;

        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");

        //gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * vertical, Space.World);

        //gameObject.transform.Rotate(0, Time.deltaTime * horizontal, 0);


        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        //if (direction.magnitude >= 0.1f)
        //    controller.Move(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            gm.IncrementPlayerScore();
           // gm.SetTimerText();
        }
    }
}
