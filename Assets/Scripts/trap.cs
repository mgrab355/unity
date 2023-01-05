using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    
    private void OnTriggerEnter2D(Collider2D trigger){
        if (trigger.gameObject.CompareTag("Player")){
            rb.freezeRotation = false;
            rb.constraints = RigidbodyConstraints2D.None;
        }
    } 

}
