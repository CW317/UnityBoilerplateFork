using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1000;
    // Update is called once per frame
    void Update()
    {
        // get rigid body
        var rb = FindAnyObjectByType<Rigidbody2D>();
        // capture left and right direction
        if (Input.GetKey(KeyCode.D))
        {
           rb.linearVelocity = (Vector2.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = (Vector2.left * Time.deltaTime * speed);
        }
    }
}
