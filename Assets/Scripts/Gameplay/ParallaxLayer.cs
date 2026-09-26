using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 0.5f;

    private Transform[] tiles;
    private float tileWidth;

    private void Awake()
    {
        tiles = new Transform[transform.childCount];
        for (int i = 0; i < tiles.Length; i++)
            tiles[i] = transform.GetChild(i);

        tileWidth = tiles[0].GetComponent<SpriteRenderer>().bounds.size.x;

        for (int i = 0; i < tiles.Length; i++)
        {
            Vector3 localPosition = tiles[i].localPosition;
            localPosition.x = tileWidth * i;
            tiles[i].localPosition = localPosition;
        }
    }

    private void Update()
    {
        if (!GameManager.Instance.IsPlaying)
            return;

        float step = GameManager.Instance.WorldSpeed * speedMultiplier * Time.deltaTime;
        float totalWidth = tileWidth * tiles.Length;

        foreach (Transform tile in tiles)
        {
            Vector3 localPosition = tile.localPosition;
            localPosition.x -= step;

            if (localPosition.x <= -tileWidth)
                localPosition.x += totalWidth;

            tile.localPosition = localPosition;
        }
    }
}
