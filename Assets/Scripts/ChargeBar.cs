using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ChargeBar : MonoBehaviour,  IPointerDownHandler,   IPointerUpHandler
{
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private float _chargePower = 5;
    [SerializeField]
    private Animator _anim;

    private bool _charging = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        _charging = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _charging = false;
    }

    private void Update()
    {
        if (_charging)
        {

            _slider.value += Time.deltaTime * _chargePower;
            _anim.speed = 1 + (_slider.value / _slider.maxValue);
        }
        else
        {

            _slider.value -= Time.deltaTime * _chargePower * 2;
            _anim.speed = 1 + (_slider.value / _slider.maxValue);
        }
    }

}
