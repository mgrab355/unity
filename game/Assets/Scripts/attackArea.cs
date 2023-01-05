using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackArea : MonoBehaviour
{
private int damage = 5;
private void OnTriggerEnter2D(Collider2D collider){
    // if (collider.gameObject.CompareTag("enemy")){
        if (collider.GetComponent<Health>() != null){
            Health hp = collider.GetComponent<Health>();
            hp.Damage(damage);
    }
}

}
