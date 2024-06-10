using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health = 100;
    private Animator animator;
    public bool dodgingLeft;
    public bool dodgingRight;
    public bool dodgingBack;
    float timeSinceDodge = 0.0f;
    float dodgeCoolDown = 0.4f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Controls
        //dodging
        if(Input.GetKeyDown(KeyCode.A)){
            if(timeSinceDodge + dodgeCoolDown < Time.time){
                animator.SetTrigger("DodgeLeft");
                timeSinceDodge = Time.time;
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(timeSinceDodge + dodgeCoolDown < Time.time){
                animator.SetTrigger("DodgeRight");
                timeSinceDodge = Time.time;
            }
        }
        if(Input.GetKeyDown(KeyCode.S)){
            if(timeSinceDodge + dodgeCoolDown < Time.time){
                animator.SetTrigger("DodgeBack");
                timeSinceDodge = Time.time;
            }
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeLeft")){
            dodgingLeft = true;
        }
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeRight")){
            dodgingRight = true;
        }
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeBack")){
            dodgingBack = true;
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")){
            //timeSinceDodge = Time.time;
        }

        //punch/parry
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("LMB key pressed");
            //punch
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("RMB key pressed");
            //parry
        }

    }

    public void TakeDamage(int damage){
        health -= damage;
        Debug.Log(health);
    }
}
