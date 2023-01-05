using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    public Transform target;
    float smoothTime = 0.3f;
    float xVelocity = 0.0f;
    float yVelocity = 0.0f;

    float zVelocity = 0.0f;


    void Update()
    {
        float newPositionX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref xVelocity, smoothTime);
        float newPositionY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        float newPositionZ = Mathf.SmoothDamp(transform.position.z, target.position.z, ref zVelocity, smoothTime);

        transform.position = new Vector3(newPositionX, newPositionY, newPositionZ);
    }
}
