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
    
    public Transform groundCheck;
    
    public LayerMask groundMask;
    
    private bool isGrounded;
    public bool isSprinting = false;

    public AudioSource _audioSource;
    public AudioClip meow01;
    public AudioClip meow02;
    public AudioClip meow03;
    public AudioClip meow04;
    [SerializeField]
    private List<AudioClip> sounds;

    private void Awake()
    {
        sounds.Add(meow01);
        sounds.Add(meow02);
        sounds.Add(meow03);
        sounds.Add(meow04);
    }

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
            
            int index = Random.Range(0, sounds.Count - 1);
            _audioSource.PlayOneShot(sounds[index]);
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
    }
}
