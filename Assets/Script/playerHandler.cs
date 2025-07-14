using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
   
    private SpriteRenderer sp;
    private Rigidbody2D rb;
    private Animator anm;

    private bool getHitProjectile = false;
    private bool getHitHands = false;

    public float moveSpeed = 30f;

    private Vector2 inputVector;

    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
    }


    void Update()
    {
        inputVector.x = Input.GetAxisRaw("Horizontal");
        inputVector.y = Input.GetAxisRaw("Vertical");

        if(!(inputVector == new Vector2(0,0)))
        {
            sp.flipX = (inputVector.x == -1);
            anm.SetBool("walk",true);
        }
        else
        anm.SetBool("walk",false);
        
        if(Input.GetMouseButton(0))
        {

        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + inputVector * moveSpeed * Time.fixedDeltaTime);
    }
}
