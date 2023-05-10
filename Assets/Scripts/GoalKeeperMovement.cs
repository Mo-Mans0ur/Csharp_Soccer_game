using UnityEngine;

public class GoalkeeperMovement : MonoBehaviour
{
    public float speed = 5f;
    public float maxDistance = 5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, maxDistance * 2f) - maxDistance;
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}


