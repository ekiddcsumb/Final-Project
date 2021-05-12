using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public float jumpHeight;
    public float sprintSpeed;
    
    private Vector3 velocity;

    private Vector3 crouchHeight = new Vector3(1f, 0.4f, 1);
    private Vector3 crouchPos;
    private Vector3 regularHeight = new Vector3(1f, 1f, 1f);
    private Vector3 regularPos;
    
    public Transform groundCheck;
    
    public LayerMask groundMask;
    
    private bool isGrounded;
    private bool isSprinting = false;

    public AudioSource _audioSource;
    public Sounds sounds;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            
            int index = Random.Range(0, sounds.getSounds().Count - 1);

            // this sound is for treats UwU
            if (index == 5)
            {
                index++;
            }
            _audioSource.PlayOneShot(sounds.getSounds()[index]);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        if (isSprinting)
        {
            move *= sprintSpeed;
        }

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        regularPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        crouchPos = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);

        transform.localScale = Input.GetKey(KeyCode.C) ? crouchHeight : regularHeight;
        transform.position = Input.GetKey(KeyCode.C) ? crouchPos : regularPos;
        controller.radius = Input.GetKey(KeyCode.C) ? .15f : .28f;
    }
}
