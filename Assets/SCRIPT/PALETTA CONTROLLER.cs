using UnityEngine;
using UnityEngine.InputSystem;

public class PALETTACONTROLLER : MonoBehaviour
{

    public InputAction moveUp;
    public InputAction moveDown;

    public Rigidbody2D body2D;

    public float moveSpeed = 5f;
    public float slowDown = 0.9f;

    public void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
    }

    public void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
    }

    public void Update()
    {
        if (moveUp.IsPressed() || moveDown.IsPressed())
        {
            if (moveUp.IsPressed())
            {
                body2D.linearVelocityY = moveSpeed;
            }
            if(moveDown.IsPressed())
            {
                body2D.linearVelocityY = -moveSpeed;
            }
        }
        else if (body2D.linearVelocityY != 0)
        {
            body2D.linearVelocityY *= slowDown;
            if(body2D.linearVelocityY > 0 && body2D.linearVelocityY < 0)
            {
                body2D.linearVelocityY *= 0;
            }
        }
    }









}
