using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinPad : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _pinInput;
    [SerializeField]
    private int _acceptedPin=1234;

    private enum PINPADVALUES
    {
        zero, one, two, three, four, five, six, seven, eight, nine, clear, enter
    }

    public void CheckInput(int value)
    {
        switch ((PINPADVALUES)value)
        {
            case PINPADVALUES.clear:
                ClearInput();
                break;
            case PINPADVALUES.enter:
                EnterInput();
                break;
            default:
                AddInput(value);
                break;
        }
    }

    private void ClearInput()
    {
        _pinInput.text = "";
    }
    private void EnterInput()
    {
        if (_pinInput.text.Equals(_acceptedPin.ToString()))
        {
            _pinInput.text = "Pin Accepted";
        }
        else
        {
            _pinInput.text = "Invalid Pin";

        }

    }
    private void AddInput(int value)
    {
        if(!string.IsNullOrWhiteSpace(_pinInput.text) && int.TryParse(_pinInput.text, out int value2))
        {
            if(_pinInput.text.Length < 4)
            {
                _pinInput.text += value.ToString();
            }
        }
        else
        {
            _pinInput.text = value.ToString();

        }

    }
}
