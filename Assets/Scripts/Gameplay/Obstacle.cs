using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(GameTags.Player))
            return;

        if (other.GetComponent<PlayerPowerUps>().IsInvincible)
            return;

        GameManager.Instance.EndGame();
    }
}
