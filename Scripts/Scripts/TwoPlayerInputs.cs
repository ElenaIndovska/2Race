using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class TwoPlayerInputs : MonoBehaviour
{

    //Player Objects
    [SerializeField]
    private GameObject Player1;
    [SerializeField]
    private GameObject Player2;

    Rigidbody rb1, rb2;


    public float speed = 50.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
       rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if players are assigned
        if (Player1 && Player2)
        {
            //Processing Player1 inputs
            if (Player1)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    //Moves Player1
                    rb1.velocity = Vector3.left * speed;
                    //Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y, Player1.transform.position.z);

                }
                if (Input.GetKey(KeyCode.A))
                {
                    //Moves Player1
                    //something like this
                    //Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);
                    rb1.velocity = Vector3.back * speed;


                }
                if (Input.GetKey(KeyCode.S))
                {
                    //Moves Player1
                    rb1.velocity = Vector3.right * speed;
                    //Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);


                }
                if (Input.GetKey(KeyCode.D))
                {
                    //Moves Player1
                    rb1.velocity = Vector3.forward * speed;
                    //Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);


                }

            }
            
       



        /*if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);

            Player1.transform.position = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Player1.transform.position = transform.TransformDirection(Player1.transform.position);
            Player1.transform.position *= speed;

            //playerOnePosition = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //playerOnePosition = transform.TransformDirection(playerOnePosition);
            //playerOnePosition *= speed;
        }*/

        //Processing Player2 inputs
        if (Player2)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    //Moves Player2
                   rb2.velocity = Vector3.back * speed;


                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    //Moves Player2
                   rb2.velocity = Vector3.forward * speed;

                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    //Moves Player2
                   rb2.velocity = Vector3.left * speed;


                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    //Moves Player2
                    rb2.velocity = Vector3.right * speed;

                }
            }
            
        }

    }
}
