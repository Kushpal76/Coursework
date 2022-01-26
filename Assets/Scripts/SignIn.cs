using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public Text output;

    public void LogIn()
    {
        

    }

    public void SignUp()
    {
        string passwordInput = password.text;
        string usernameInput = username.text;

        if (passwordInput.Length == 0 || usernameInput.Length == 0)
        {
            output.text = "Enter username and password";
        }
        else 
        { 
            if (passwordInput.Length < 4)
            {
                output.text = "Your password is too short";
            }
            else
            {
                if (passwordInput == usernameInput)
                {
                    output.text = "Your password cannot be the same as your username";
                }
                else
                {
                    output.text = "";
                }
            }
        }
    }
}
