using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpThermo : MonoBehaviour
{
    [SerializeField] string _tagName;
    [SerializeField]
    public float _addThermo;
    float _timed;
    [SerializeField] float _span;
    [SerializeField]
    bool _isStart;
    [SerializeField]
    GameManager _gameManager;
    public float AddThermo { get => _addThermo; set => _addThermo = value; }

    private void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _timed += Time.deltaTime;
        if (_timed > _span)
        {
            if (collision.gameObject.tag == _tagName)
            {
                _gameManager.CurrentThermo(AddThermo);
                Debug.Log(collision.gameObject.tag);
            }
            _timed = 0f;
        }
    }
}