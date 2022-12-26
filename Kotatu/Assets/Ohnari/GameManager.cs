using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class GameManager : MonoBehaviour
{
    static GameManager _instance;
    static public GameManager Instance => _instance;
    [SerializeField, Tooltip("重なっていない時に減る温度")]
    float _downThermo = default;
    [SerializeField]
    int _maxThermo = 100;
    [SerializeField] GameObject _image = default;
    Image _ima;
    [SerializeField, Tooltip("カウントダウンのイメージ")]
    Image _countIma = default;
    [SerializeField]
    Image _startIma = default;
    [SerializeField]
    Image _finishIma = default;
    [SerializeField, Header("タイマー関連"), Tooltip("タイマーテキスト")]
    Text _timerText = default;
    [SerializeField]
    float _timer = 30.0f;
    [SerializeField, Header("数字のspriteとStartのSprite")]
    Sprite[] _numberIma = default;
    [SerializeField] float _currentThermo;
    [SerializeField] float _span;
    [SerializeField] float _timed;
    bool _isStart;
    /// <summary>タイマーのプロパティ</summary>
    public float Timer { get => _timer; set => _timer = value; }
    /// <summary>スタートフラグ</summary>
    public bool IsStart { get => _isStart; set => _isStart = value; }
    /// <summary>勝利フラグ</summary>
    bool _isWinPlayer, _isWinKotatsu;
    public bool IsWinPlayer { get => _isWinPlayer; set => _isWinPlayer = value; }
    public bool IsWinKotatsu { get => _isWinKotatsu; set => _isWinKotatsu = value; }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        _countIma.gameObject.SetActive(false);
        _startIma.gameObject.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(CountDown());
        _ima = _image.GetComponent<Image>();

    }
    void FixedUpdate()
    {
        if (_isStart && _timer >= 0)
        {
            _timer -= Time.deltaTime;
            _timerText.text = $"{_timer:00.00}";
        }
        else if (_timer <= 0)
        {
            _timerText.gameObject.SetActive(false);
            _isStart = false;
            _finishIma.gameObject.SetActive(true);
            _isWinKotatsu = true;
        }
        if(_currentThermo>=100)
        {
            _isWinPlayer = true;
            _isStart = false;
        }
        if (_isStart)
        {
            _timed += Time.deltaTime;
            if (_timed > _span)
            {
                DownThermo();
                _timed = 0f;
            }
        }
        //Debug.Log(_currentThermo);
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

    public void CurrentThermo(float num)
    {
        Instance._currentThermo += num;
    }

    public void hpdown(float current, int max)
    {
        //imageというコンポーネントのfillamountを取得して操作する
        _ima.fillAmount = current / max;
    }
    public void DownThermo()
    {
        _currentThermo = _currentThermo - _downThermo;
        hpdown(_currentThermo, _maxThermo);
        if(_currentThermo<=0)
        {
            _currentThermo = 0;
        }
    }
}
