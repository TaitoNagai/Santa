using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource[]_bgmAudio = default;
    [SerializeField] GameManager _gameManager = default;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameManager.IsWinKotatsu||_gameManager.IsWinPlayer)
        {
            _bgmAudio[0].enabled = false;
            _bgmAudio[1].enabled = true;
        }
    }
}
