using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    private float jumpForce = 13f;
    
    
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up *((byte)jumpForce), ForceMode2D.Impulse);
        }
    } 

}
