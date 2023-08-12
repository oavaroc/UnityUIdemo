using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileScript : MonoBehaviour
{
    public static TileScript instance;
    [SerializeField]
    private TextMeshProUGUI _output;
    [SerializeField]
    private GameObject _grid;
    [SerializeField]
    private GameObject[] _tiles;

    private int _score = 0;
    private List<GameObject> _currentBoard;

    private void Start()
    {
        instance = this;
        _currentBoard = new List<GameObject>();
    }
    public void NewBoard()
    {
        foreach(GameObject go in _currentBoard)
        {
            Destroy(go);
        }
        for(int i = 0; i < 15; i++)
        {
            _currentBoard.Add(Instantiate(_tiles[Random.Range(0,3)], _grid.transform));
        }
    }

    public void UnveilTile(int value)
    {
        _score += value;
        _output.text = _score.ToString();
    }
}
