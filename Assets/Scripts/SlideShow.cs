using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideShow : MonoBehaviour
{

    public enum Slide
    {
        Slide1,
        Slide2,
        Slide3,
        Slide4,
    }

    [System.Serializable]
    public class SlideVisuals
    {
        public Slide slide;
        public Sprite sprite;
        public string labelText;
    }

    [SerializeField]
    private ToggleGroup _tg;

    [SerializeField]
    private Image _slideImage;

    [SerializeField]
    private TextMeshProUGUI _slideText;

    [SerializeField]
    private SlideVisuals[] _slideVisuals;
    private void Start()
    {

        SetSlideVisuals(Slide.Slide1);
    }
    public void ToggleTrue(Toggle toggle)
    {
        if (toggle.isOn)
        {
            SlideToggle slideToggle = toggle.GetComponent<SlideToggle>();

            if (slideToggle != null)
            {
                Slide selectedslide = slideToggle.slide;
                SetSlideVisuals(selectedslide);
            }
        }
    }

    private void SetSlideVisuals(Slide slide)
    {
        foreach (var visuals in _slideVisuals)
        {
            if (visuals.slide == slide)
            {
                _slideImage.sprite = visuals.sprite;
                _slideText.text = visuals.labelText;
                break;
            }
        }
    }
}
