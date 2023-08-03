using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float h, v;
    private bool isJumping;
    private bool isRunning;
    private int count = 1;
    [SerializeField]private int Jumppower;
    
    
    
    private Rigidbody2D rigid;
    private Animator anim;
    
    
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anim.GetBool("isJumping") && count > 0)
            {
                rigid.AddForce(Vector2.up*Jumppower,ForceMode2D.Impulse);
                count=0;
                anim.SetBool("isDoubleJumping",true);
            }
            
            if (!anim.GetBool("isJumping"))
            {
                rigid.AddForce(Vector2.up*Jumppower,ForceMode2D.Impulse);
                anim.SetBool("isJumping", true);
            }

            
        }
        
        
        
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground"))
        {
            anim.SetBool("isJumping",false);
            anim.SetBool("isDoubleJumping",false);
            count = 1;
        }
    }
}
