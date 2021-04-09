using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    [SerializeField] Entity entity;

    private MoveScript moveScript;
    private float speed;
    private Vector2 moveDirection;

    private bool isJoystickEnabled = true;
    void Start()
    {
        moveScript = GetComponent<MoveScript>();
        speed = entity.MoveSpeed;
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
                moveScript.Move(joystick.Direction.normalized, speed);
                break;
            case false:
                moveScript.Move(moveDirection, speed);
                break;
        }

        Debug.Log(joystick.Direction);

        if (Input.GetKeyDown(KeyCode.R))
        {
            moveScript.ResetPosition();
        }
    }
    void EnableDisableJoystick()
    {
        isJoystickEnabled = !isJoystickEnabled;
    }
}
