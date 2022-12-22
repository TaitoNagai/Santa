using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour
{
    [SerializeField]
    string _name;

    public void OnButtomDown()
    {
        SceneManager.LoadScene("MainScene");
    }
}
