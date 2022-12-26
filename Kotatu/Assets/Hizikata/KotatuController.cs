using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KotatuController : MonoBehaviour
{
    [SerializeField, Tooltip("‰Á‚¦‚é—Í")]
    Vector2 _power;
    Rigidbody2D _rb;
    [SerializeField]
    GameManager _gameManager = default;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    _rb.velocity = Vector2.zero;
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    _rb.velocity = Vector2.zero;
        //}
    }
    private void FixedUpdate()
    {
        if (_gameManager.IsStart)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rb.AddForce(-_power);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rb.AddForce(_power);
            }
        }
    }
}
