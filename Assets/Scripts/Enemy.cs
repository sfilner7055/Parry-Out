using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 100;
    int damage = 15;
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
        if(timeSinceLastAttack + 0.1f < Time.time & !attacking){
            attacking = true;
            attackNum = Random.Range(1,6);
            animator.SetInteger("AttackList", attackNum);
            attacksInARow += 1;
            Debug.Log(attacksInARow);
        }

        if(health <= 0){
            Debug.Log("erm");
            Destroy(this);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && attacking)
        {
            player.GetComponent<Player>().TakeDamage(damage);
        }
        if(other.tag == "Fist"){
            health -= 50;
        }
    }

    public void StopAttack()
    {
        attacking = false;
        timeSinceLastAttack = Time.time;
        animator.SetInteger("AttackList", 0);  
    }

}
