using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float MoveSpeed= 5000f;
    Animator animator;
    Rigidbody2D body;
    SpriteRenderer flip;
    void Start()
    {
        animator = GetComponent<Animator>();
        body= GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
 
        /* if(! Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S )){
            body.velocity = new Vector2(0,0);
            animator.SetBool("KeyDown",false);
            
        } */
        if(Input.GetKey(KeyCode.W)){
            body.velocity = new Vector2(0,MoveSpeed * Time.deltaTime);
            animator.SetBool("Direction",true);
            flip.flipY = true;
        }
        if(Input.GetKey(KeyCode.S)){
            body.velocity = new Vector2(0,-MoveSpeed * Time.deltaTime);
            animator.SetBool("Direction",true);
            flip.flipY = false;
        }
        if(Input.GetKey(KeyCode.A)){
            body.velocity = new Vector2(-MoveSpeed * Time.deltaTime,0);
            animator.SetBool("Direction",false);
            flip.flipX = true;
        }
        if(Input.GetKey(KeyCode.D)){
            body.velocity = new Vector2(MoveSpeed * Time.deltaTime,0);
            animator.SetBool("Direction",false);
            flip.flipX = false;
        }
        
    }
}
