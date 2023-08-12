using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float _maxHP=100f;
    private float _currentHP = 100f;

    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private TextMeshProUGUI _text;
    private void Start()
    {
        AlterHealth(0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            AlterHealth(-20);
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            AlterHealth(20);
        }
    }

    public void AlterHealth(float damage)
    {
        _currentHP = Mathf.Clamp(_currentHP+damage,0,_maxHP);
        _slider.value = _currentHP;
        _text.text = _currentHP.ToString();

    }
}
