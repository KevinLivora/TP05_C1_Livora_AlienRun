using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D body;
    private Collider2D bodyCollider;
    private float jumpForce;
    private KeyCode jumpKey;
    private bool jumpRequested;
    private bool isGrounded;

    public bool IsGrounded => isGrounded;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        bodyCollider = GetComponent<Collider2D>();

        jumpForce = data.jumpForce;
        jumpKey = data.jumpKey;
        body.gravityScale = data.gravityScale;
    }

    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
            jumpRequested = true;
    }

    private void FixedUpdate()
    {
        isGrounded = bodyCollider.IsTouchingLayers(groundLayer);

        if (jumpRequested && isGrounded)
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        jumpRequested = false;
    }
}
