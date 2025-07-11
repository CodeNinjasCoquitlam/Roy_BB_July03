﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Speed of movement")]
    public float speed;
    public enum MovementType
    {
        AllDirections,
        HorizontalOnly,
        VerticalOnly
    }

    [Header("Animator")]
    public Animator animator;

    [SerializeField]
    private MovementType movementType = 0;

    [Header("Platform Movement")]
    [Tooltip("Adjusts Movement for Platform Games")]
    public bool platformSettings = false;

    private float masterSpeed;




    void Awake()
    {
        masterSpeed = speed;        
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (platformSettings)
        {
            Rigidbody2D rigidBody;
            rigidBody = GetComponent<Rigidbody2D>();
            float verticalMovement = rigidBody.velocity.y;
            if (verticalMovement != 0)
            {
                speed = masterSpeed / 3;
            }
            else
            {
                speed = masterSpeed;
            }
        }

        switch (movementType)
        {
            case MovementType.HorizontalOnly:
                vertical = 0f;
                break;
            case MovementType.VerticalOnly:
                horizontal = 0f;
                break;
        }

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Restart"))
        {
            SceneManager.LoadScene(0);
        }
    }

}

