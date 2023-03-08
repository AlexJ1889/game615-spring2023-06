using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;

    public GameManager gm;
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
            gm.SetTimerText();
        }
    }
}
