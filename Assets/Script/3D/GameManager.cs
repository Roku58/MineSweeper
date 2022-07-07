using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private GameManager() { }
    public static GameManager Instance
    {
        get { return instance; }

    }

    public void Init()
    {
        Application.targetFrameRate = 30;
    }
}
