using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveScript : MonoBehaviour
{
    private Rigidbody2D entityRB2D;

    private void Start()
    { 
        entityRB2D = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction, float speed)
    {
        entityRB2D.MovePosition(entityRB2D.position + direction * speed * Time.deltaTime);
    }

    public void ResetPosition()
    {
        entityRB2D.position = Vector3.zero;
        entityRB2D.velocity = Vector3.zero;
    }
}
