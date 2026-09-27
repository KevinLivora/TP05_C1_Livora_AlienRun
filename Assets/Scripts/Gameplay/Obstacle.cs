using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(GameTags.Player))
            return;

        PlayerPowerUps powerUps = other.GetComponent<PlayerPowerUps>();
        if (powerUps.IsInvincible)
            return;

        GameManager.Instance.HandlePlayerHit(powerUps);
    }
}