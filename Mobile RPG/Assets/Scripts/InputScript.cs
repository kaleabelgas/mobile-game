using UnityEngine;

[RequireComponent(typeof(MoveScript))]
public class InputScript : MonoBehaviour
{
    Joystick joystick;

    private MoveScript moveScript;
    private Vector2 moveDirection;

    private bool isJoystickEnabled = true;
    public int Speed { get; set; }

    void Start()
    {
        moveScript = GetComponent<MoveScript>();
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        //temp code
        //moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
        moveDirection.Normalize();

        if (Input.GetKeyDown(KeyCode.J))
        {
            EnableDisableJoystick();
        }


        //Debug.Log(joystick.Direction);

        if (Input.GetKeyDown(KeyCode.R))
        {
            moveScript.ResetPosition();
        }


    }
    private void FixedUpdate()
    {

        moveScript.Move(isJoystickEnabled ? joystick.Direction.normalized : moveDirection, Speed);
    }
    void EnableDisableJoystick()
    {
        isJoystickEnabled = !isJoystickEnabled;
    }

}
