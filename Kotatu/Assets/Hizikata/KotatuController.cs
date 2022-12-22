using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KotatuController : MonoBehaviour
{
    [SerializeField, Tooltip("‰Á‚¦‚é—Í")]
    Vector2 _power;
    Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddForce(-_power);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddForce(_power);
        }
    }
}
