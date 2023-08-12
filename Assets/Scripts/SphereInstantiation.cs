using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInstantiation : MonoBehaviour
{
    [SerializeField]
    private GameObject _orb;
    [SerializeField]
    private Transform _pos1;
    [SerializeField]
    private Transform _pos2;
    private GameObject _orb1;
    private GameObject _orb2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnOrbs());
    }

    IEnumerator SpawnOrbs()
    {
        while (true)
        {
            _orb1 = Instantiate(_orb, _pos1.position, Quaternion.identity);
            _orb2 = Instantiate(_orb, _pos2.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
            Destroy(_orb1);
            Destroy(_orb2);

        }
    }
}
