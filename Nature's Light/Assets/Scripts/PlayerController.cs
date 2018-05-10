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
        animator.SetBool("IsRunningLeft", false);
        animator.SetBool("IsRunningRight", false);
        animator.SetBool("IsRunningUp", false);
        animator.SetBool("IsRunningDown", false);
        animator.SetBool("IsIdle", true);
    }

    void Update()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;

        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            animator.SetBool("IsRunningUp", true);
        }
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            animator.SetBool("IsRunningDown", true);
        }
        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            animator.SetBool("IsRunningLeft", true);
        }
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            animator.SetBool("IsRunningRight", true);
        }

        if (Input.GetKeyUp("up") || Input.GetKeyUp("w"))
        {
            animator.SetBool("IsRunningUp", false);
        }
        if (Input.GetKeyUp("down") || Input.GetKeyUp("s"))
        {
            animator.SetBool("IsRunningDown", false);
        }
        if (Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            animator.SetBool("IsRunningLeft", false);
        }
        if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            animator.SetBool("IsRunningRight", false);
        }

        if (animator.GetBool("IsRunningRight") || animator.GetBool("IsRunningLeft") ||
            animator.GetBool("IsRunningUp") || animator.GetBool("IsRunningDown"))
        {
            animator.SetBool("IsIdle", false);
        }
        else
        {
            animator.SetBool("IsIdle", true);
        }
    }
}
