using UnityEngine;

public class ScrollingLayer : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 1f;
    [SerializeField] private float loopWidth = 1f;

    private Vector3 startPosition;
    private float traveledDistance;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (!GameManager.Instance.IsPlaying)
            return;

        float step = GameManager.Instance.WorldSpeed * speedMultiplier * Time.deltaTime;
        traveledDistance = Mathf.Repeat(traveledDistance + step, loopWidth);
        transform.position = startPosition + Vector3.left * traveledDistance;
    }
}
