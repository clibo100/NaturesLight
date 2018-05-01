using UnityEngine;
using System.Collections;

// PlayerScript requires the GameObject to have a Rigidbody2D component

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public float playerSpeed = 4f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;

        animator.SetBool("IsRunningLeft", false);
        animator.SetBool("IsRunningRight", false);
        animator.SetBool("IsRunningUp", false);
        animator.SetBool("IsRunningDown", false);

        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            animator.SetBool("IsRunningUp", true);
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            animator.SetBool("IsRunningDown", true);
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            animator.SetBool("IsRunningLeft", true);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            animator.SetBool("IsRunningRight", true);
        }
    }
}
