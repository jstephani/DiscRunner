using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private float moveSpeed = 5f;

    public float runSpeed = 20f;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        //horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        //vertical = Input.GetAxisRaw("Vertical"); // -1 is down
        rb.velocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}

