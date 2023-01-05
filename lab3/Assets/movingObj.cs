using UnityEngine;

public class movingObj : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 10.0f;
    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 targetPos;
        if (movingRight)
        {
            targetPos = startPos + new Vector3(distance, 0, 0);
        }
        else
        {
            targetPos = startPos;
        }
        Vector3 direction = (targetPos - transform.position ).normalized;
        transform.Translate(direction * speed * Time.deltaTime );

        if (transform.position == targetPos)
        {
            movingRight = !movingRight;
        }
    }
}

