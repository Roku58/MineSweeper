using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] Material _openmaterial;
    bool _isOpen;
    public bool isOpen { get ; private set; } 
    

    public void Open()
    {
        isOpen = true;
        GetComponent<Renderer>().material = _openmaterial;
    }
}
