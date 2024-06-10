using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 100;
    int damage = 20;
    string directionNeededToDodge;
    float timeSinceLastAttack = 0;
    bool attacking;
    int attacksInARow = 0;

    private Animator animator;
    GameObject player;
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(timeSinceLastAttack + 1f < Time.time){
            Attack(Random.Range(1,5));
        }
    }

    void Attack(int attackNum){
        attacking = true;
        animator.SetInteger("AttackList", attackNum);
        /*if(attackNum == 1){
            directionNeededToDodge = "Right";
        }
        if(attackNum == 2){
            directionNeededToDodge = "Left";
        }
        if(attackNum == 3 || attackNum == 4 || attackNum == 5){
            directionNeededToDodge = "Down";
        }*/
        timeSinceLastAttack = Time.time;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<Player>().TakeDamage(damage);
        }
    }
}
