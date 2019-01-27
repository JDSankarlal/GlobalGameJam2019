using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Use this for initialization
    public float moveSpeed;
    int currentLane;
    bool lerping = true;
    private float movementCounter;
    //private CharacterController _controller;


    void Start()
    {
        currentLane = 2;
        movementCounter = 0;
        // _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

         //Debug.Log("Lerping is currently: " + lerping);
        if (Input.GetKey(KeyCode.W))
        {
             transform.position += (new Vector3(0, moveSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
           transform.position += (new Vector3(0, -moveSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            currentLane--;
            if (currentLane >= 0)
            {
                movementCounter = 0;
            }
            else
            {
                currentLane++;
            }
            //if (currentLane == 1 || currentLane == 3)
            //{
            //    lerping = true;
            //}
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            currentLane++;
            if (currentLane <= 3)
            {
                movementCounter = 0;
            }
            else
            {
                currentLane--;
            }
            //if (currentLane == 1 || currentLane == 2)
            //{
            //    lerping = true;
            //}
        }

             movementCounter += Time.deltaTime * moveSpeed;
             if (movementCounter > 1)
             {
                 movementCounter = 1;
             }
            if (currentLane == 1)
            {

                transform.position = Vector2.Lerp(transform.position, new Vector2(-1.80f, transform.position.y), movementCounter); //Move to Lane 2 
            }


            if (currentLane == 2)
            {
                transform.position = Vector2.Lerp(transform.position, new Vector2(-0.011f, transform.position.y), movementCounter );

            }

            if (currentLane == 3)
            {
                transform.position = Vector2.Lerp(transform.position, new Vector2(1.90f, transform.position.y), movementCounter );
            }

        //if (transform.position.x == -1.80f) //If in Lane 2
        //{
        //    lerping = false;
        //    currentLane = 2;
        //}
        //
        //if (transform.position.x == -0.011f) //If in Lane 1
        //{
        //    lerping = false;
        //    currentLane = 1;
        //}
        //
        //if (transform.position.x == 1.90f)
        //{
        //    lerping = false;
        //    currentLane = 3;
        //}

      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
        Destroy(gameObject);
    }
}



