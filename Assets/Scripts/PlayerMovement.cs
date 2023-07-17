using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PlayerMovement : MonoBehaviour
{
    public bool Grounded=true;
    public Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;


    private enum MovementState { idle, running, jumping, falling }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    public void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
       

        if (Input.GetButtonDown("Jump")&&Grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        float speed;
        speed =rb.velocity.x;
        if(speed<0){
            sprite.flipX = true;
        }
        if(speed>0){
            sprite.flipX = false;
        }
        
        
        anim.SetFloat("Speed",Mathf.Abs(speed));

        if(rb.velocity.y > .1f&&!Grounded)
        {
            anim.SetBool("IsJumping",true);
            anim.SetBool("IsFalling",false);
        }
        else if (rb.velocity.y < -.1f&&!Grounded)
        {
            anim.SetBool("IsFalling",true);
            anim.SetBool("IsJumping",false);
        }else{
            anim.SetBool("IsFalling",false);
            anim.SetBool("IsJumping",false);

        }

       // UpdateAnimationState();
    }

     public void OnCollisionEnter2D(Collision2D collision){
            Grounded=true;
            Debug.Log("+calisti");
    
     }

         public void OnCollisionExit2D(Collision2D collision){
            Grounded=false;
            Debug.Log("-calisti");
    }



   /* private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }

        else if (rb.velocity.y > -.1f)
        {
            state = MovementState.falling;
        }

       // anim.Setnteger("state",(int)state);
    }
    */
}
