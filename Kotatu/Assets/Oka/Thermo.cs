using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thermo : MonoBehaviour
{
    [SerializeField] GameObject _image = default;
    Image _ima;
    void Start()
    {
        _ima = _image.GetComponent<Image>();
    }

    //()�̒��g�͈����A���̂Ƃ��납�琔�l�𓾂�{}�̒��Ŏg��
    public void hpdown(float current, int max)
    {
        //image�Ƃ����R���|�[�l���g��fillamount���擾���đ��삷��
        _ima.fillAmount = current / max;
    }
}
