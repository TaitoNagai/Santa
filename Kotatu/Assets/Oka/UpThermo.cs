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
    public float AddThermo { get => _addThermo; set => _addThermo = value; }

    private void Update()
    {
        _timed += Time.deltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_timed > _span)
        {
            if (collision.gameObject.tag == _tagName)
            {
                GameManager.CurrentThermo(AddThermo);
                Debug.Log(AddThermo);
            }
            _timed = 0f;
        }
    }
}
