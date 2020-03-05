﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideLeftJump : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall")
        {
            player.GetComponent<BallMovement>().isRightJumpGrounded = false;
            player.GetComponent<BallMovement>().isLeftJumpGrounded = true;
            player.GetComponent<BallMovement>().isGrounded = false;

        }
    }


}
