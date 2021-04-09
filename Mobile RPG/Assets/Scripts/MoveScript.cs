using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Rigidbody2D playerRB2D;

    private void Start()
    { 
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction, float speed)
    {
        playerRB2D.MovePosition(playerRB2D.position + direction * speed * Time.deltaTime);
        Debug.Log("moving: " + direction + speed);
    }

    public void ResetPosition()
    {
        playerRB2D.position = Vector3.zero;
        playerRB2D.velocity = Vector3.zero;
    }
}
