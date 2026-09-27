using UnityEngine;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    private const string IsGroundedParam = "IsGrounded";

    private PlayerController player;
    private Animator animator;

    private void Awake()
    {
        player = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        player.Jumped += OnJumped;
        player.Landed += OnLanded;
    }

    private void OnDisable()
    {
        player.Jumped -= OnJumped;
        player.Landed -= OnLanded;
    }

    private void Update()
    {
        animator.speed = GameManager.Instance.IsPlaying ? 1f : 0f;
    }

    private void OnJumped() => animator.SetBool(IsGroundedParam, false);

    private void OnLanded() => animator.SetBool(IsGroundedParam, true);
}