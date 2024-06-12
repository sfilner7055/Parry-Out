using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int health = 100;
    private Animator animator;
    public bool dodging = false;

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

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeLeft") || animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeBack") || animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeRight")){
            dodging = true;
        }
        else{
            dodging = false;
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")){
            //timeSinceDodge = Time.time;
        }

        if(health <= 0){
            SceneManager.LoadScene("GameOver");
        }

    }

    public void TakeDamage(int damage){
        health -= damage;
        Debug.Log(health);
    }
}
