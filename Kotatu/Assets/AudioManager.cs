using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource[]_audio = default;
    [SerializeField] GameManager _gameManager = default;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameManager.IsWinKotatsu||_gameManager.IsWinPlayer)
        {
            _audio[0].Stop();
            _audio[1].Play();
        }
    }
}
