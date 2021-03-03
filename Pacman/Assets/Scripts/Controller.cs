using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float MoveSpeed= 5000f;
    Animator animator;
    Rigidbody2D pacman;
    SpriteRenderer flip;
    void Start()
    {
        animator = GetComponent<Animator>();
        pacman= GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
    }


    /* private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "leftCollider") {
            pacman.position = new Vector2(0,0);
        } else if(other.gameObject.tag == "rightCollider") {
            
        }
    } */
    // Update is called once per frame
    void FixedUpdate()
    {
 
        if(pacman.position.x < -7.5) {
            pacman.position = new Vector2(-0.4f,pacman.position.y);
        }

        else if(pacman.position.x > -0.4) {
            pacman.position = new Vector2(-7.5f,pacman.position.y);
        }
        /* if(! Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S )){
            body.velocity = new Vector2(0,0);
            animator.SetBool("KeyDown",false);
            
        } */
        if(Input.GetKey(KeyCode.W)){
            pacman.velocity = new Vector2(0,MoveSpeed * Time.deltaTime);
            animator.SetBool("Direction",true);
            flip.flipY = true;
        }
        if(Input.GetKey(KeyCode.S)){
            pacman.velocity = new Vector2(0,-MoveSpeed * Time.deltaTime);
            animator.SetBool("Direction",true);
            flip.flipY = false;
        }
        if(Input.GetKey(KeyCode.A)){
            pacman.velocity = new Vector2(-MoveSpeed * Time.deltaTime,0);
            animator.SetBool("Direction",false);
            flip.flipX = true;
        }
        if(Input.GetKey(KeyCode.D)){
            pacman.velocity = new Vector2(MoveSpeed * Time.deltaTime,0);
            animator.SetBool("Direction",false);
            flip.flipX = false;
        }
        
    }
}
