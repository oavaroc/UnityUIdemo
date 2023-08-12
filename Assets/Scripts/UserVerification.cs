using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserVerification : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _username;
    [SerializeField]
    private TMP_InputField _createUsername;
    [SerializeField]
    private TMP_InputField _password;
    [SerializeField]
    private TMP_InputField _createPassword;
    [SerializeField]
    private TMP_InputField _confirmPassword;
    [SerializeField]
    private TextMeshProUGUI _output;

    private Dictionary<string, string> _playerBase;
    private void Start()
    {
        _playerBase = new Dictionary<string, string>();
    }
    public void CreateNewAccount()
    {
        if (_createPassword.text.Equals(_confirmPassword.text))
        {
            if (_createUsername.text.Length >= 5 && _createPassword.text.Length >= 5)
            {
                if (_playerBase.TryAdd(_createUsername.text, _createPassword.text))
                {
                    _output.text = "User added successfully";
                    RefreshFields();
                }
                else
                {
                    _output.text = "User already exists";
                }
            }
            else
            {
                _output.text = "Username and Password must be at least 5 characters long";
            }
        }
        else
        {
            _output.text = "Passwords must match";
        }
    }
    public void Login()
    {
        if(_playerBase.TryGetValue(_username.text,out string value))
        {
            if (value.Equals(_password.text))
            {
                _output.text = "Login Successful";
                RefreshFields();
            }
            else
            {
                _output.text = "incorrect password";
            }
        }
        else
        {
            _output.text = "incorrect password";
        }
    }
    public void RefreshFields()
    {
        _username.text = "";
        _createUsername.text = "";
        _password.text = "";
        _createPassword.text = "";
        _confirmPassword.text = "";
    }
}
