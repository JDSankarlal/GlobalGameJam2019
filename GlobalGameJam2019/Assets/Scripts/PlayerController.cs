using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Use this for initialization
    public float moveSpeed;
    //private CharacterController _controller;


    void Start () {
       // _controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
    
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (new Vector3(0, moveSpeed,0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (new Vector3(0,  - moveSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
        }

    }
}
