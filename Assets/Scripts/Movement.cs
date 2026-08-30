using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 8f;
    private bool isFacingRight = true;

    private Vector2 lastMoveDirection = Vector2.down;

    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Flip();
    }

    private void FixedUpdate()
    {
        Vector2 moveInput = new Vector2(horizontal, vertical).normalized;
        rb.linearVelocity = moveInput * speed;

        if (moveInput != Vector2.zero)
            lastMoveDirection = moveInput;
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}