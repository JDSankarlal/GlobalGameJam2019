using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPhysics : MonoBehaviour {

   private Rigidbody2D playerMovement;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
        playerMovement = GetComponent<Rigidbody2D>();
        playerMovement.velocity = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerMovement.velocity = new Vector2(0,moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerMovement.velocity = new Vector2(0, - moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerMovement.velocity = new Vector2(-moveSpeed, 0 );
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerMovement.velocity = new Vector2(moveSpeed,0);
        }

    }
}
