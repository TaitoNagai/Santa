using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    [SerializeField,Tooltip("カウントダウンのテキスト")]
    Text _countText = default;
    [SerializeField,Header("タイマー関連"), Tooltip("タイマーテキスト")]
    Text _timerText = default;
    [SerializeField]
    float _timer = 30.0f;
    /// <summary>タイマーのプロパティ</summary>
    public float Timer { get => _timer; set => _timer = value; }
    /// <summary>スタートフラグ</summary>
    bool _isStart;
    void Start()
    {
        StartCoroutine(CountDown());
    }
    void Update()
    {        
        if(_isStart&&_timer>=0)
        {
            _timer -= Time.deltaTime;
            _timerText.text = $"残り{_timer:00.00}秒";
        }
        else if(_timer<=0)
        {
            _timerText.gameObject.SetActive(false);
            _isStart = false;
        }
    }
    /// <summary>カウントダウンのコルーチン</summary>
    public IEnumerator CountDown()
    {
        _isStart = false;
        yield return new WaitForSeconds(1.0f);
        _countText.text = "3";
        yield return new WaitForSeconds(1.0f);
        _countText.text = "2";
        yield return new WaitForSeconds(1.0f);
        _countText.text = "1";
        yield return new WaitForSeconds(1.0f);
        _countText.text = "Start";
        yield return new WaitForSeconds(1.0f);
        Destroy(_countText);
        _isStart = true;
        yield return null;
    }
}
