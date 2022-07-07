using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = GameManager.Instance;
        _gameManager.Init();
    }

    private enum STATE
    {
        DEFAULT = 0,
    }
    private STATE _state = STATE.DEFAULT;

    private void Update()
    {
        switch (_state)
        {
        
        }

    }
}
