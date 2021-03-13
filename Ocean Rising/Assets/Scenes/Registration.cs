using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registration : MonoBehaviour
{
    public InputField usernameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWW www = new WWW("http://localhost/sqlconnect/register.php");
    }
}
