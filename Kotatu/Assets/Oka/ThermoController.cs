using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoController : MonoBehaviour
{

    //最大hp、半端な数にした
    [SerializeField]
    int _maxThermo = 100;
    //現在のhp
    [SerializeField]
    float _currentThermo = default;
    //重なった時に増える温度
    [SerializeField, Tooltip("重なった時に増える温度")]
    float _upThermo = default;
    //重なっていないときに減る温度
    [SerializeField, Tooltip("重なっていない時に減る温度")]
    float _downThermo = default;
    [SerializeField] GameObject _ondkeinaka;

    void Start()
    {
    }

    void Update()
    {
        //hpsystemのスクリプトのhpdown関数に2つの数値を送る
        
    }

    public void UpThermo()
    {
            _currentThermo = _currentThermo + Time.time * _upThermo;
    }
    public void DownThermo()
    {
        _currentThermo = _currentThermo + Time.time * _downThermo;
    }
}
