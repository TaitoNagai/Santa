using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 _playerMove;
    Rigidbody2D _playerRigidbody;
    [SerializeField]
    GameManager _gameManager = default;
    [SerializeField]
    GameObject _target = default;
    [SerializeField]
    UpThermo _upthermo = default;
    [SerializeField,Header("ターゲットとの距離")]
    float dir;
    float _timed;
    [SerializeField] float _span;
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
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
            dir = Vector3.Distance(_target.transform.position, this.transform.position);
            Debug.Log(dir);
            if (dir < 1.5)
            {
                _timed += Time.deltaTime;
                if (_timed > _span)
                {
                    _gameManager.CurrentThermo(_upthermo.AddThermo);
                    //Debug.Log(_upthermo.AddThermo);
                    
                }
            }
        }
    }
}
