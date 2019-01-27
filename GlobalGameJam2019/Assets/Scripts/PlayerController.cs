using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Use this for initialization
    public float moveSpeed;
    int currentLane;
    bool lerping = false;
    //private CharacterController _controller;


    void Start()
    {
        currentLane = 1;

        // _controller = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Lerping is currently: " + lerping);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (new Vector3(0, moveSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (new Vector3(0, -moveSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (currentLane == 1 || currentLane == 3)
            {
                lerping = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            if (currentLane == 1 || currentLane == 2)
            {
                lerping = true;
            }
        }       

        if (lerping == true)
        {

            if (currentLane == 1)
            {
                transform.position = Vector2.Lerp(transform.position, new Vector2(-1.80f, transform.position.y), moveSpeed * Time.deltaTime); //Move to Lane 2 
            }

           //if (currentLane == 1)
           //{
           //    transform.position = Vector2.Lerp(transform.position, new Vector2(1.90f, transform.position.y), moveSpeed * Time.deltaTime); //Move to Lane 2 
           //}
           //
            if (currentLane == 2)
            {
               transform.position = Vector2.Lerp(transform.position, new Vector2(-0.011f, transform.position.y), moveSpeed * Time.deltaTime);
            }

            if (currentLane == 3)
            {
                transform.position = Vector2.Lerp(transform.position, new Vector2(1.90f, transform.position.y), moveSpeed * Time.deltaTime);
            }
           
        }
    }











}

