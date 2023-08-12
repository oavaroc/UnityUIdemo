using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed = 5f;


    [SerializeField] private Slider _healthBarSlider;

    private float _currentHealth;
    private float _maxHealth = 100f;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void AlterHealth(float damage)
    {
        _currentHealth -= damage;
        _healthBarSlider.value = _currentHealth / _maxHealth;

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.transform.position, _player.transform.position, Time.deltaTime * _speed) ;   
    }
}
