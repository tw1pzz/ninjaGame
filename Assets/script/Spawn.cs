using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject coinPrefab;

    [HideInInspector] Vector2 lastPosition = Vector2.zero;
    [HideInInspector] float timer;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            lastPosition = new Vector2(lastPosition.x + 168f, Random.Range(-lastPosition.y - 50, lastPosition.y + 50));
            Vector2 coinPosition = new Vector2(lastPosition.x, lastPosition.y + 36f);
            Instantiate(coinPrefab, coinPosition, quaternion.identity);
            Instantiate(platformPrefab, lastPosition, Quaternion.identity);
            timer = 0.8f;
        }
    }
}