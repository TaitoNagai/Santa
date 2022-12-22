using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TitleManager : MonoBehaviour
{
    [SerializeField,Tooltip("‘€ìà–¾‚ÌƒCƒ[ƒW")]
    Image _explainIma = default;
    [SerializeField]
    Button[]_explainButton = default;
    void Start()
    {
        _explainButton[0].onClick.AddListener(() => _explainIma.gameObject.SetActive(true));
        _explainButton[0].onClick.AddListener(() => _explainButton[1].gameObject.SetActive(false));
        _explainButton[0].onClick.AddListener(() => _explainButton[2].gameObject.SetActive(false));
    }
}
