using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CellState
{

    None = 0,//空セル

    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,

    Mine = -1,//地雷
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

    private void OnValidate()//インスペクター上での変更が反映。変更する度エディター実行される
    {
        OnCellStateChanged();
    }

    void OnCellStateChanged()
    {
        if (!_view) return;
        if (_cellstate == CellState.Mine)//地雷
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
