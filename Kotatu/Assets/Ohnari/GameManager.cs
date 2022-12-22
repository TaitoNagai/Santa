using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    [SerializeField,Tooltip("カウントダウンのイメージ")]
    Image _countIma = default;
    [SerializeField]
    Image _startIma = default;
    [SerializeField,Header("タイマー関連"), Tooltip("タイマーテキスト")]
    Text _timerText = default;
    [SerializeField]
    float _timer = 30.0f;
    [SerializeField, Header("数字のspriteとStartのSprite")]
    Sprite[] _numberIma = default;
    /// <summary>タイマーのプロパティ</summary>
    public float Timer { get => _timer; set => _timer = value; }
    /// <summary>スタートフラグ</summary>
    bool _isStart;
    /// <summary>勝利フラグ</summary>
    bool _isWinPlayer, _isWinKotatsu;
    private void Awake()
    {
        _countIma.gameObject.SetActive(false);
        _startIma.gameObject.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(CountDown());
        
    }
    void Update()
    {        
        if(_isStart&&_timer>=0)
        {
            _timer -= Time.deltaTime;
            _timerText.text = $"{_timer:00.00}";
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
        _countIma.gameObject.SetActive(true);
        _countIma.sprite = _numberIma[2];
        yield return new WaitForSeconds(1.0f);
        _countIma.sprite = _numberIma[1];
        yield return new WaitForSeconds(1.0f);
        _countIma.sprite = _numberIma[0];
        yield return new WaitForSeconds(1.0f);
        _startIma.gameObject.SetActive(true);
        _countIma.gameObject.SetActive(false);
        _startIma.sprite = _numberIma[3];
        yield return new WaitForSeconds(1.0f);
        _startIma.gameObject.SetActive(false);
        _isStart = true;
        yield return null;
    }
    /// <summary>ゲームの勝敗を判定する関数</summary>
    public void Judge()
    {
    }
}
