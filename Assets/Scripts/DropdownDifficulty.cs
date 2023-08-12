using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownDifficulty : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown _difficulty;
    [SerializeField]
    private TextMeshProUGUI _output;

    public void ChangeDifficulty()
    {
        _output.text = "You have selected difficulty: " + _difficulty.options[_difficulty.value].text;
        AdjustGameDifficulty(_difficulty.value); // Call a function to modify game difficulty
    }
    private void AdjustGameDifficulty(int difficultyIndex)
    {
        // Implement logic to adjust game difficulty based on selected index
    }
}
