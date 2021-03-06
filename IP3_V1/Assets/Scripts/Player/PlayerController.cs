﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //General Declarations
    public float speed = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (this.gameObject.tag == "Player1")
        {
            float horMove1 = Input.GetAxis("Horizontal_P1");
            float verMove1 = Input.GetAxis("Vertical_P1"); 
            GetComponent<Rigidbody>().velocity = new Vector3(horMove1 * speed, 0, verMove1 * speed);
        }

        if (this.gameObject.tag == "Player2")
        {
            float horMove2 = Input.GetAxis("Horizontal_P2");
            float verMove2 = Input.GetAxis("Vertical_P2");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove2 * speed, 0, verMove2 * speed);
        }

        if (this.gameObject.tag == "Player3")
        {
            float horMove3 = Input.GetAxis("Horizontal_P3");
            float verMove3 = Input.GetAxis("Vertical_P3");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove3 * speed, 0, verMove3 * speed);
        }

        if (this.gameObject.tag == "Player4")
        {
            float horMove4 = Input.GetAxis("Horizontal_P4");
            float verMove4 = Input.GetAxis("Vertical_P4");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove4 * speed, 0, verMove4 * speed);
        }

    }
}
