using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Trigger : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    bool canInteract = true;
    float coolDown = 0;
    int damage = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(coolDown + 1f < Time.time){
            Debug.Log(collision.gameObject.name);
            damage += 1;
            coolDown = Time.time;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(damage);
    }
}
