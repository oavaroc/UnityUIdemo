using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnveilScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _cover;
    private void Start()
    {
        StartCoroutine(HideRoutine());
    }
    public void Unveil(int value)
    {
        TileScript.instance.UnveilTile(value);
    }
    IEnumerator HideRoutine()
    {
        _cover.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        _cover.SetActive(true);
    }
}
