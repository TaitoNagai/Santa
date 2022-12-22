using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 _playerMove;
    Rigidbody2D _playerRigidbody;
    [SerializeField]
    GameManager _gameManager = default;
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (_gameManager.IsStart)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _playerRigidbody.AddForce(-_playerMove);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _playerRigidbody.AddForce(_playerMove);
            }
        }
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    _playerRigidbody.velocity = Vector2.zero;
        //}
        //else if (Input.GetKeyUp(KeyCode.D))
        //{
        //    _playerRigidbody.velocity = Vector2.zero;
        //}
    }
}
