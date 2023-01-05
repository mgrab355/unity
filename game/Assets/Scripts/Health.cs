using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField] public class Health : MonoBehaviour
{
    private int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(int amount){
        if(amount < 0){
            throw new  System.ArgumentOutOfRangeException("cannot have negetive damage");
        }
        this.hp -= amount;
        if(hp<=0){
            Die();
       }

    }
    private void Die(){
        Destroy(gameObject);
    }
}
