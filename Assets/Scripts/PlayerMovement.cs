using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController charController;

    [SerializeField] float jumpSpeed = 20.0f;
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;

    [SerializeField] float moveSpeed = 5.0f;
    public float h;
    public float v;

    public Animator anim; //Variables that are stating the character controller, jumpSpeed, gravity, yVelocity, moveSpeed, horizontal and vertical

    void Start()
    {
        charController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>(); //Sets up the character controller and the animator
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", v);
        anim.SetFloat("Direction", h);

        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * moveSpeed;

        if (charController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                anim.SetTrigger("Jump");
                yVelocity = jumpSpeed;
            }

        }
        else
        {
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;

        velocity = transform.TransformDirection(velocity);

        charController.Move(velocity * Time.deltaTime);
    }

}