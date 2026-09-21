using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(PlayerTag))
            GameManager.Instance.EndGame();
    }
}
