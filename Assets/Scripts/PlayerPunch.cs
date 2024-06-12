using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPunch : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    bool canInteract = true;
    Enemy enemy;
    Player player;
    void Start()
    {
        animator = GetComponent<Animator>();
        enemy = GameObject.Find("Isometric Diamond").GetComponent<Enemy>();
        player = GameObject.Find("Player").GetComponent<Player>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            if(canInteract & !player.dodging){
                animator.SetTrigger("Player");
            }
        }


    }
}
