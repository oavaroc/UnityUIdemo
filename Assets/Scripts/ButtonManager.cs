using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum DifficultyLevel
{
    Easy,
    Medium,
    Hard
}

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private ToggleGroup _tg;
    [SerializeField]
    private TextMeshProUGUI _text;
    [SerializeField]
    private Image _image;

    public void ToggleTrue(Toggle toggle)
    {
        if (toggle.isOn)
        {
            DifficultyLevel selectedDifficulty;

            switch (toggle.tag)
            {
                case "Easy":
                    selectedDifficulty = DifficultyLevel.Easy;
                    break;
                case "Medium":
                    selectedDifficulty = DifficultyLevel.Medium;
                    break;
                case "Hard":
                    selectedDifficulty = DifficultyLevel.Hard;
                    break;
                default:
                    selectedDifficulty = DifficultyLevel.Easy; // Default value
                    break;
            }

            Debug.Log("Game set to: " + selectedDifficulty);
        }
    }
}