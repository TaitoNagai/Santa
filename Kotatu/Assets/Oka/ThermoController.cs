using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoController : MonoBehaviour
{

    //�ő�hp�A���[�Ȑ��ɂ���
    [SerializeField]
    int _maxThermo = 100;
    //���݂�hp
    [SerializeField]
    float _currentThermo = default;
    //�d�Ȃ������ɑ����鉷�x
    [SerializeField, Tooltip("�d�Ȃ������ɑ����鉷�x")]
    float _upThermo = default;
    //�d�Ȃ��Ă��Ȃ��Ƃ��Ɍ��鉷�x
    [SerializeField, Tooltip("�d�Ȃ��Ă��Ȃ����Ɍ��鉷�x")]
    float _downThermo = default;
    [SerializeField] GameObject _ondkeinaka;

    void Start()
    {
    }

    void Update()
    {
        //hpsystem�̃X�N���v�g��hpdown�֐���2�̐��l�𑗂�
        //_ondkeinaka.GetComponent<Thermo>().hpdown(_currentThermo, _maxThermo);
    }

    //fixedupdate�͈��ɌĂ΂��̂Ŏ����I�Ɏg�������ɗǂ��炵��
    void Fixedupdate()
    {
        //currenthp��0�ȏ�Ȃ�true
        if (0 <= _currentThermo)
        {
            //maxhp����b���i�~10�j������������currenthp
            _currentThermo = _currentThermo + Time.deltaTime * _upThermo;
        }
    }
}
