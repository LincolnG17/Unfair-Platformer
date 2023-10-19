using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float acceleration = 50f;
    public float deceleration = 40f;
    public float maxSpeed = 4f;
    public float friction = 30f;
    public float jumpPower = 10f;
    public float ascendingGravity = 20f;
    public float descendingGravity = 30f;

    private bool isJumping = false;
    public bool isOnGround = false;
    private bool isAscending = false;

    private Rigidbody2D rb;
    public Vector3 MyStartPosition;
    public Animator myAnimator;

    public Sprite deadSprite;
    public SpriteRenderer mySpriteRenderer;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        MyStartPosition = transform.position;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void Update()
    {
        // Check for jump input
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        // Check if the player is on the ground
        //isOnGround = Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Ground"));

        // Calculate horizontal movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float xVelocity = rb.velocity.x;

        if (horizontalInput != 0)
        {
            // Apply acceleration
            xVelocity += acceleration * horizontalInput * Time.fixedDeltaTime;

            // Clamp velocity to maximum speed
            xVelocity = Mathf.Clamp(xVelocity, -maxSpeed, maxSpeed);
        }
        else
        {
            // Apply deceleration
            float decelerationMultiplier = deceleration * Time.fixedDeltaTime;
            if (xVelocity > 0)
            {
                xVelocity = Mathf.Max(0, xVelocity - decelerationMultiplier);
            }
            else if (xVelocity < 0)
            {
                xVelocity = Mathf.Min(0, xVelocity + decelerationMultiplier);
            }
        }

        // Apply friction
        float frictionMultiplier = friction * Time.fixedDeltaTime;
        if (isOnGround)
        {
            xVelocity = Mathf.Lerp(xVelocity, 0f, frictionMultiplier);
        }

        // Apply movement
        rb.velocity = new Vector2(xVelocity, rb.velocity.y);

        // Adjust gravity based on ascending or descending
        if (rb.velocity.y > 0.01)
        {
            rb.gravityScale = ascendingGravity;
            isAscending = true;
        }
        else
        {
            rb.gravityScale = descendingGravity;
            isAscending = false;
        }
    }

    private void Jump()
    {
        isJumping = true;
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        myAnimator.SetTrigger("Jump");
    }

    private void SetDeadSprite()
    {
        mySpriteRenderer.sprite = deadSprite;
    }

}