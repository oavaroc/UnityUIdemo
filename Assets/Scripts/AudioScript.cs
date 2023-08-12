using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class AudioScript : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]
    private AudioClip _audioClip;
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private float _pitch;


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0))
        {
            PlayKey();
        }
    }
    public void PlayKey()
    {
        _audioSource.pitch = _pitch;
        _audioSource.PlayOneShot(_audioClip);
    }
}
