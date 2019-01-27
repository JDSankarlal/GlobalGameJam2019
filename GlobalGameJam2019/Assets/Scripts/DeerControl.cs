using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerControl : MonoBehaviour
{

    public GameObject player;

    public int moveSpeed;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Deer Spawned");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (new Vector3(0, -moveSpeed, 0) * Time.deltaTime);

       if (transform.position.y <-5.5)
        {
            Destroy(gameObject);
        }
    }


}
