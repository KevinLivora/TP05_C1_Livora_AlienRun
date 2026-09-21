using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class WorldMover : MonoBehaviour
{
    [SerializeField] private float despawnX = -12f;

    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float speed = GameManager.Instance.IsPlaying ? GameManager.Instance.WorldSpeed : 0f;
        body.linearVelocity = Vector2.left * speed;

        if (transform.position.x < despawnX)
            Destroy(gameObject);
    }
}
