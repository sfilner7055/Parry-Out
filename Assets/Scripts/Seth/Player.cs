using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Controls

        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("A key pressed");
            //play dodge left animation
            //give i-frames
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Debug.Log("D key pressed");
            //play dodge right animation
            //give i-frames
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Debug.Log("S key pressed");
            //play dodge back animation
            //give i-frames
        }
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("LMB key pressed");
            //punch
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("RMB key pressed");
            //parry
        }
    }
}
