using System;
using UnityEngine;

public class upDown : MonoBehaviour
{
    public float speed = 4.0f;
    public float distance = 10.0f;
    private Vector2 startPos;
    private Vector2[] positions = new Vector2[] { new Vector2(38, 14 ), new Vector2(38, 25 )};
    private Vector2 targetPos;
    void Start()
    {
        startPos = transform.position;
        targetPos = positions[1];
    }

    void Update()
    {
        Vector2 direction = (targetPos - (Vector2)transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, targetPos) < 0.01)
        {
            var array_index = Array.IndexOf(positions, targetPos) + 1;
            if (array_index >= positions.Length)
            {
                array_index = 0;
            }
            targetPos = positions[array_index];
        }
    }
}

