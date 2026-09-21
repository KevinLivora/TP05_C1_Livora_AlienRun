using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [FormerlySerializedAs("obstaclePrefabs")]
    [SerializeField] private GameObject[] prefabs;
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
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
        Vector3 position = new Vector3(transform.position.x, prefab.transform.position.y, 0f);
        Instantiate(prefab, position, Quaternion.identity);
    }

    private void ResetTimer()
    {
        timer = Random.Range(minInterval, maxInterval);
    }
}
