using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class MineSweper : MonoBehaviour
{
    [SerializeField] GridLayoutGroup _gridLayoutGroup = default;
    [SerializeField] Cell _cellprefab = default;
    [SerializeField] int _row = 10;
    [SerializeField] int _column = 10;
    [SerializeField] int _mineCount = 10;
    Cell[,] _cells;

    void Start()
    {
        _gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        _gridLayoutGroup.constraintCount = _column;

        _cells = new Cell[_row, _column];
        for(var r = 0; r < _row; r++)
        {
            for (var c = 0; c < _column; c++)
            {
                var cell = Instantiate(_cellprefab, _gridLayoutGroup.transform);
                //オブジェクト型にしないことでセル以外を選択できないようにしている（型安全性）

                _cells[r, c] = cell;
            }
        }
        for(var i = 0; i < _mineCount; i++)
        {
            var r = Random.Range(0, _row);
            var c = Random.Range(0, _column);
            _cells[r, c].Cellstate = CellState.Mine;
        }
    }

}
