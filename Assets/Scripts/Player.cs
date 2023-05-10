using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float kickForce = 10.0f;
    public float kickDistance = 2.0f;
    public GameObject ball;
    [SerializeField] private float moveSpeed = 7f;

    private void Update()
    {
        Vector2 inputVector = new Vector2(0,0);

        if (Input.GetKey(KeyCode.D)){
            inputVector.y = +1;
        }
        if  (Input.GetKey(KeyCode.A)){
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.W)){
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.S)){
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed* Time.deltaTime ;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            KickBall();
        }
    }

    private void KickBall()
    {
        float distanceToBall = Vector3.Distance(transform.position, ball.transform.position);
        if(kickDistance <= kickDistance)
        {
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            Vector3 kickDirection = transform.forward;
            ballRigidbody.AddForce(kickDirection * kickForce, ForceMode.Impulse);
        } 
    }
    

}
