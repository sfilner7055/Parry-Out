using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 100;
    int damage = 1;
    float timeSinceLastAttack = 0;
    public bool attacking = false;
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
        if(timeSinceLastAttack + 0.5f < Time.time & !attacking){
            attacking = true;
            attackNum = Random.Range(1,6);
            animator.SetInteger("AttackList", attackNum);
            attacksInARow += 1;
        }


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
        timeSinceLastAttack = Time.time;
        animator.SetInteger("AttackList", 0);  
    }

}
