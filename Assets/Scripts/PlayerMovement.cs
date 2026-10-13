using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float inGroundDumping;
    private bool isGrounded;
    public Rigidbody2D rb;
    void Start()
    {
        // get rigid body
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // capture left and right direction
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        
        if (isGrounded && 
            (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
            isGrounded = false;
        }
        
        if(isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX * inGroundDumping, rb.linearVelocity.y);
        }
    }

    // mark grounded if it touches an object with the tage ground
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
