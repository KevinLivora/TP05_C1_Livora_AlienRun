using UnityEngine;

[RequireComponent(typeof(Animator))]
public class GameplayAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.speed = GameManager.Instance.IsPlaying ? 1f : 0f;
    }
}