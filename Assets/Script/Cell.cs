using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CellState
{

    None = 0,//��Z��

    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,

    Mine = -1,//�n��
}

public class Cell : MonoBehaviour
{
    [SerializeField] Text _view = null;
    [SerializeField] CellState _cellstate = CellState.None;

    public CellState Cellstate
    {
        get => _cellstate;
        set
        {
            _cellstate = value;
            OnCellStateChanged();
        }
    }
    void Start()
    {
        OnCellStateChanged();
    }

    private void OnValidate()//�C���X�y�N�^�[��ł̕ύX�����f�B�ύX����x�G�f�B�^�[���s�����
    {
        OnCellStateChanged();
    }

    void OnCellStateChanged()
    {
        if (!_view) return;
        if (_cellstate == CellState.Mine)//�n��
        {
            _view.text = "X";
            _view.color = Color.red;

        }
        else if (_cellstate == CellState.None)
        {
            _view.text = "";
        }
        else
        {

            _view.text = ((int)_cellstate).ToString();
            _view.color = Color.blue;
        }
    }
}
