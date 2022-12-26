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
        //_ondkeinaka.GetComponent<Thermo>().hpdown(_currentThermo, _maxThermo);
    }

    //fixedupdateは一定に呼ばれるので持続的に使う処理に良いらしい
    void Fixedupdate()
    {
        //currenthpが0以上ならtrue
        if (0 <= _currentThermo)
        {
            //maxhpから秒数（×10）を引いた数がcurrenthp
            _currentThermo = _currentThermo + Time.deltaTime * _upThermo;
        }
    }
}
