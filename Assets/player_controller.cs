using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Animator fox_animator;
    public Rigidbody2D rb;
    private int hspeed;
    private float speed = 4f;
   
    private void Update()
    {
        hspeed = 0;
        if(Input.GetKey(KeyCode.A))
        {
            hspeed = -1;
            fox_animator.SetBool("running", true);
        }
        
        else if(Input.GetKey(KeyCode.D))
        {
            hspeed = 1;
            fox_animator.SetBool("running", true);
        }
        else{
            fox_animator.SetBool("running", false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 30f);
        }

        if(hspeed != 0) {
            transform.localScale = new Vector3(hspeed, 1, 1);
        }

        rb.velocity = new Vector2(hspeed*speed, rb.velocity.y);
    }
}