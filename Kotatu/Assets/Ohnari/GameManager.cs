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
    [SerializeField, Tooltip("�d�Ȃ��Ă��Ȃ����Ɍ��鉷�x")]
    float _downThermo = default;
    [SerializeField]
    int _maxThermo = 100;
    [SerializeField] GameObject _image = default;
    Image _ima;
    [SerializeField, Tooltip("�J�E���g�_�E���̃C���[�W")]
    Image _countIma = default;
    [SerializeField]
    Image _startIma = default;
    [SerializeField, Header("�^�C�}�[�֘A"), Tooltip("�^�C�}�[�e�L�X�g")]
    Text _timerText = default;
    [SerializeField]
    float _timer = 30.0f;
    [SerializeField, Header("������sprite��Start��Sprite")]
    Sprite[] _numberIma = default;
    [SerializeField] float _currentThermo;
    [SerializeField] float _span;
    [SerializeField] float _timed;
    bool _isStart;
    /// <summary>�^�C�}�[�̃v���p�e�B</summary>
    public float Timer { get => _timer; set => _timer = value; }
    /// <summary>�X�^�[�g�t���O</summary>
    public bool IsStart { get => _isStart; set => _isStart = value; }
    /// <summary>�����t���O</summary>
    bool _isWinPlayer, _isWinKotatsu;
    private void Awake()
    {
        _countIma.gameObject.SetActive(false);
        _startIma.gameObject.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(CountDown());
        _ima = _image.GetComponent<Image>();

    }
    void Update()
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
        }

        _timed += Time.deltaTime;
        if (_timed > _span)
        {
            DownThermo();
            Debug.Log("a");
            _timed = 0f;
        }
    }
    /// <summary>�J�E���g�_�E���̃R���[�`��</summary>
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
    /// <summary>�Q�[���̏��s�𔻒肷��֐�</summary>
    public void Judge()
    {
    }

    public void CurrentThermo(float num)
    {
        Instance._currentThermo += num;
        hpdown(_currentThermo, _maxThermo);
    }

    public void hpdown(float current, int max)
    {
        //image�Ƃ����R���|�[�l���g��fillamount���擾���đ��삷��
        _ima.fillAmount = current / max;
    }
    public void DownThermo()
    {
        _currentThermo = _currentThermo - _downThermo;
        hpdown(_currentThermo, _maxThermo);
    }
}
