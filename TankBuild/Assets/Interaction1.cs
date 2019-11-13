﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // pick up flag
        if (collision.gameObject.name == "Flag2")
        {
            collision.gameObject.SetActive(false);
            gameObject.GetComponent<PlayerStats>().hasFlag = true;
            // TODO add something that shows flag on tank
        }

        // Win the game if flag is dropped at the drop zone
        if (collision.gameObject.tag == "Drop1" && gameObject.GetComponent<PlayerStats>().hasFlag == true)
        {
            Debug.Log("Player 1 WINS");
        }
    }
}