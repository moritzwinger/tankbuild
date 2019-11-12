﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float moveSpeed;
    // Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement 
        transform.Rotate(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal2") * moveSpeed * 20 * Time.deltaTime));
        transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical2") * moveSpeed * Time.deltaTime));

    }
}
