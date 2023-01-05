using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class flip : MonoBehaviour
{
public AIPath aiPath;
    void Update(){
        if(aiPath.desiredVelocity.x >= 0.1f)
        {
            transform.localScale = new Vector3(-4.20f, 4.20f, 4.20f);
        } else if(aiPath.desiredVelocity.x <= -0.1f){
            transform.localScale = new Vector3(4.20f, 4.20f, 4.20f);
            
        }
}
}
