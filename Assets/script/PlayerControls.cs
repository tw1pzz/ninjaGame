using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody.velocity = new Vector2(3, rigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 7);
        }
    }
}
