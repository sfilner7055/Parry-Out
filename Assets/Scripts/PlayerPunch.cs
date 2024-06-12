using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPunch : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    bool canInteract = true;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            if(canInteract == true){
                animator.SetTrigger("Player");
            }
        }
    }
}
