using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInput : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _inputFieldCreatPIN;
    [SerializeField]
    private TMP_InputField _inputFieldPIN;
    [SerializeField]
    private TextMeshProUGUI _outputText;

    private int _pin;
    public void CreatePin()
    {
        if (_inputFieldCreatPIN.text.Length < 4)
        {
            _outputText.text = "PIN must be 4 characters";
        }
        else if (int.TryParse(_inputFieldCreatPIN.text, out int result))
        {
            _inputFieldCreatPIN.gameObject.SetActive(false);
            _inputFieldPIN.gameObject.SetActive(true);
            _pin = result;
        }
    }
    public void InputPin()
    {
        if (_inputFieldPIN.text.Length < 4)
        {
            _outputText.text = "PIN must be 4 characters";
        }
        else if (int.TryParse(_inputFieldPIN.text, out int result))
        {
            _outputText.text = (_pin==result? Correct() : Incorrect());
        }
    }

    private string Correct()
    {
        _inputFieldPIN.gameObject.SetActive(false);
        _inputFieldCreatPIN.gameObject.SetActive(true);
        return "PIN verified";
    }
    private string Incorrect()
    {
        return "Incorrect PIN";
    }
}
