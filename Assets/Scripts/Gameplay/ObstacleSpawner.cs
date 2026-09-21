using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private float minInterval = 1f;
    [SerializeField] private float maxInterval = 2.2f;

    private float timer;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        if (!GameManager.Instance.IsPlaying)
            return;

        timer -= Time.deltaTime;
        if (timer > 0f)
            return;

        Spawn();
        ResetTimer();
    }

    private void Spawn()
    {
        GameObject prefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        Vector3 position = new Vector3(transform.position.x, prefab.transform.position.y, 0f);
        Instantiate(prefab, position, Quaternion.identity);
    }

    private void ResetTimer()
    {
        timer = Random.Range(minInterval, maxInterval);
    }
}
