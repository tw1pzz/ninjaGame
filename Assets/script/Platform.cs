using UnityEngine;

public class Platform : MonoBehaviour
{
    [HideInInspector] GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (transform.position.x < player.transform.position.x - 150)
        {
            Destroy(gameObject);
        }
    }
}
