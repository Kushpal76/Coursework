using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private BoxCollider2D collide;
    [SerializeField] private LayerMask jumpableGround; // This sets the ground layer to jumpable ground

    private float horizontalForce = 0f; // This will be used to store the input value for horizontal movement
    private float moveSpeed = 7f; // This is used to control how fast the player will move horizontally
    private float jumpForce = 15f; // This is used to control how high the player moves when the jump key is pressed

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collide = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        horizontalForce = Input.GetAxisRaw("Horizontal");   // This gets the direction and the ammount of force that will be applied horizontally
        body.velocity = new Vector2(horizontalForce * moveSpeed, body.velocity.y); // The player moves in they y axis the amount of force applied times the moveSpeed

        if (Input.GetButtonDown("Jump") && IsGrounded()) // This checks if the jump button is being pressed and the player is on the ground
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce); // The player will jump a certain height dependant on the value of jumpForce
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(collide.bounds.center, collide.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
        // This returns true if the player is on the ground
    }
}
