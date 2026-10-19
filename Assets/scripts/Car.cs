using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 0.5f;
    public float distance = 1f;

    Vector3 start;
    Vector3 end;
    float waitTime = 3f;

    void Start()
    {
        start = transform.position;
        end = start + new Vector3(1, -1, 0).normalized * distance;
    }

    void Update()
    {
        if (waitTime > 0)
        {
            waitTime -= Time.deltaTime;
            return;
        }

        transform.position = Vector3.MoveTowards(
            transform.position, end, speed * Time.deltaTime
        );

        if (transform.position == end)
        {
            end = start;
            start = transform.position;

            waitTime = 3f;
        }
    }
}