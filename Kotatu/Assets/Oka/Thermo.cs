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

    //()の中身は引数、他のところから数値を得て{}の中で使う
    public void hpdown(float current, int max)
    {
        //imageというコンポーネントのfillamountを取得して操作する
        _ima.fillAmount = current / max;
    }
}
