using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_attack : MonoBehaviour
{

    private GameObject attackArea = default;
    private bool attacking = false;
    private float timeToAttack = 0.15f;
    private float timer = 0f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(1).gameObject;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            Attack();
        }
        if(attacking){
            timer += Time.deltaTime;
            if(timer>=timeToAttack){
                timer=0;
                attacking=false;
                attackArea.SetActive(attacking);
                animator.SetBool("attack", false);
            }
        }
    }
    private void Attack(){
        attacking = true;
        attackArea.SetActive(attacking);
        animator.SetBool("attack",true);
    }
}
