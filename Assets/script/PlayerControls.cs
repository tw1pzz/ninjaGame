using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;

    private Rigidbody2D _playerRigidbody;
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }
    private void Update()
    {
       // MovePlayer();

        if (Input.GetButton("Jump"))
            Jump();
        _playerRigidbody.velocity = new Vector2(playerSpeed, _playerRigidbody.velocity.y);
        

        if (transform.position.y < -150)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);

    }

    private void Jump() => _playerRigidbody.velocity = new Vector2(0, jumpPower);
}