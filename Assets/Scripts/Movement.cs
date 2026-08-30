using UnityEngine;

public class Movement : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    private float speed = 8f;
    private bool isFacingUp = true;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
        rb.linearVelocity = new Vector2(vertical * speed, rb.linearVelocity.x);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale
        }

        if (isFacingUp && vertical < 0f || !isFacingUp && vertical > 0f)
        {
            isFacingUp = !isFacingUp;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale
        }
    }
}
