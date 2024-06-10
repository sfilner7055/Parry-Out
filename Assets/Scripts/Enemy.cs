using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 100;
    int damage = 1;
    float timeSinceLastAttack = 0;
    bool attacking = false;
    public int attacksInARow = 0;
    int attackNum = 0;

    private Animator animator;
    GameObject player;
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(timeSinceLastAttack + 3f < Time.time){
            attackNum = 
            animator.SetInteger("AttackList", Random.Range(1,5));  
            timeSinceLastAttack = Time.time;
        }
    }

    void Attack(int attackNum){
        //g
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && attacking)
        {
            player.GetComponent<Player>().TakeDamage(damage);
        }
    }

    public void StopAttack()
    {
        attacking = false;
    }
}
