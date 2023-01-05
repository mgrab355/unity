using System;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 10.0f;
    private Vector3 startPos;
    private Vector3[] positions = new Vector3[] { new Vector3(0, 0, 0), new Vector3(10, 0, 0), new Vector3(10, 10, 0), new Vector3(0, 10, 0) };
    private Vector3 targetPos;
    void Start()
    {
        startPos = transform.position;
        targetPos = positions[1];
    }

    void Update()
    {
        Vector3 direction = (targetPos - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, targetPos) < 0.01)
        {
            this.transform.Rotate(0, 0, 90, Space.Self);
            var array_index = Array.IndexOf(positions, targetPos) + 1;
            if (array_index >= positions.Length)
            {
                array_index = 0;
            }
            targetPos = positions[array_index];
        }
    }
}

