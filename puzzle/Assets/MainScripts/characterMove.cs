using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    Vector3 velocity;

    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Transform groundCheck;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = Vector3.zero; // Initialize move vector to zero

        if (x != 0 || z != 0) // Check if there is input from the player
        {
            move = transform.right * x + transform.forward * z;
        }


        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
