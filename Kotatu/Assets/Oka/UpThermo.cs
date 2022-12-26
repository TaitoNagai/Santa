using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpThermo : MonoBehaviour
{
    [SerializeField] string _tagName;
    [SerializeField]
    public float _addThermo;
    [SerializeField] GameManager _gameManager = default;
    public float AddThermo { get => _addThermo; set => _addThermo = value; }
}
