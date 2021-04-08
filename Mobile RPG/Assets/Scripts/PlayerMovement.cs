using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    [SerializeField] float playerSpeed;

    private Rigidbody2D playerRB2D;
    private Vector2 moveDirection;

    private bool isJoystickEnabled = true;



    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //temp code
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (Input.GetKeyDown(KeyCode.J))
        {
            EnableDisableJoystick();
        }
        switch (isJoystickEnabled)
        {
            case true:
                Move(joystick.Direction.normalized, playerRB2D.position);
                break;
            case false:
                Move(moveDirection, playerRB2D.position);
                break;
        }

        Debug.Log(joystick.Direction);

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
    }

    void Move(Vector2 direction, Vector2 currentLocation)
    {
        //playerRB2D.AddForce(direction * playerSpeed * Time.deltaTime, ForceMode2D.Impulse);
        //playerRB2D.velocity += direction * playerSpeed * Time.deltaTime;
        playerRB2D.MovePosition(currentLocation + direction * playerSpeed * Time.deltaTime);

    }

    void ResetPosition()
    {
        playerRB2D.position = Vector3.zero;
        playerRB2D.velocity = Vector3.zero;
    }

    void EnableDisableJoystick()
    {
        isJoystickEnabled = !isJoystickEnabled;
    }
}
