using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultJudge : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField]
    GameObject[] _resultPanel = default;
    [SerializeField] string _name = null;
    private void Start()
    {
        //if(_gameManager.)
        //{
        //    _resultPanel[0].SetActive(true);
        //}
        //else if(_gameManager.)
        //{
        //    _resultPanel[1].SetActive(true);
        //}
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(_name);
        }
    }
}
