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
    }

    private void Update()
    {
        
        if (_gameManager.IsWinPlayer)
        {
            _resultPanel[0].SetActive(true);
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene(_name);
            }
        }
        else if (_gameManager.IsWinKotatsu)
        {
            _resultPanel[1].SetActive(true);
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene(_name);
            }
        }
    }
}
