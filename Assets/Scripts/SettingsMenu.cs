using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.Rendering.Universal;

public class SettingsMenu : MonoBehaviour
{
    private PlayerInputActions _input;
    [SerializeField]
    private GameObject _settingsMenu;
    [SerializeField]
    private Slider _brightnessBar;
    [SerializeField]
    private Slider _volumeBar;
    [SerializeField]
    private AudioMixer _audioMixer;
    [SerializeField]
    private Volume _postProcessProfile;
    private ColorAdjustments _colorAdjustments;

    private bool _inSettings = false;

    // Start is called before the first frame update
    void Start()
    {
        _postProcessProfile.profile.TryGet(out _colorAdjustments);
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Player.Settings.performed += Settings_performed;
    }

    private void Settings_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Cancel(!_inSettings);
    }

    public void AdjustBrightness()
    {
        if (_colorAdjustments != null)
        {
            _colorAdjustments.postExposure.value=(_brightnessBar.value);
        }
    }
    public void AdjustVolume()
    {
        _audioMixer.SetFloat("Master", _volumeBar.value) ;
    }
    public void Cancel(bool inSetting)
    {
        _inSettings = inSetting;
        _settingsMenu.SetActive(_inSettings);
        Time.timeScale = _inSettings ? 0f : 1f;
    }
}
